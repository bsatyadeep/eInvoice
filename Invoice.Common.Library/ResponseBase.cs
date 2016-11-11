using System;
using System.Runtime.Serialization;

namespace Invoice.Common.Library
{
    public enum OperationResult
    {
        Unknown,
        Success,
        Exception,
        Failure
    }
    [DataContract]
    public class ResponseBase
    {

        #region Constrcutor
        public ResponseBase()
        {
            this.Status = OperationResult.Unknown;
            this.FriendlyErrorMessage = String.Empty;
            this.ErrorMessage = String.Empty;
        }
        #endregion

        [DataMember]
        public OperationResult Status { get; set; }
        [DataMember]
        public String FriendlyErrorMessage { get; set; }
        [DataMember]
        public String ErrorMessage { get; set; }
    }
}
