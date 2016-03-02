using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTrader.Windows
{
    public abstract class ViewModel : ObservableObject,  IDataErrorInfo
    {
        public ViewModel()
        {
            this.PropertyChanged += ViewModel_PropertyChanged;
        }

        public Action onPropertyChangedAction { get; set; }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (onPropertyChangedAction != null)
                onPropertyChangedAction();
        }

        public string this[string propertyName]
        {
            get
            {
                return OnValidate(propertyName);
            }
        }
        
        public string Error
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public bool IsValid
        {
            get
            {
                var context = new ValidationContext(this);
                var results = new Collection<ValidationResult>();
                var isValid = Validator.TryValidateObject(this, context, results, true);
                return isValid;
            }
        }
        
        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this) { MemberName = propertyName };

            var results = new Collection<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);

            var property = results.Where(r => r.MemberNames != null && r.MemberNames.Any(t => t == propertyName));

            var propertyValid = !property.Any();

            return !propertyValid ? property.FirstOrDefault().ErrorMessage : null;
        }
    }
}
