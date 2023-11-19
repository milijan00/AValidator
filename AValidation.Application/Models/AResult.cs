using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AValidation.Application.Models
{
    public class AResult
    {
        #region Variables
        private List<string> _errors;
        private bool _valid;
        #endregion

        public AResult()
        {
            _errors = new List<string>();
            _valid = false;
        }

        #region Properties
        public List<string> Errors
        {
            get => this._errors;
        }

        public bool Valid
        {
            get => this._valid; set { this._valid = value; }
        }
        #endregion

        #region Public Methods

        public void ValidationSuccessful()
        {
            if(!_errors.Any())
                this._valid = true;
        }

        public void ValidationFailed(string error)
        {
            if (string.IsNullOrEmpty(error))
                throw new ArgumentException("Error must not be null or empty.");

            this.AddError(error);

            this._valid = false;
        }
        #endregion

        #region Private Methods
        private void AddError(string error)
        {
            this.Errors.Add(error);

        }
        #endregion
    }
}
