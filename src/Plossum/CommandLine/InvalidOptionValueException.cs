using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Plossum.CommandLine
{
    /// <summary>
    /// Exception that may be thrown by the setter method of a property or a method attributed with the <see cref="CommandLineOptionAttribute"/>.
    /// </summary>
    /// <remarks>Throwing this exception from a setter method of a property or a method with the attribute <see cref="CommandLineOptionAttribute"/>
    /// will cause the command line parser to insert an error message indicating that there was an error on the command line, after which it 
    /// will continue to parse the rest of the command line. The error can later be retrieved using the property <see cref="CommandLineParser.Errors"/>.
    /// </remarks>
    [Serializable]
    public class InvalidOptionValueException : ParseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOptionValueException"/> class.
        /// </summary>
        public InvalidOptionValueException()
            : base(String.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOptionValueException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public InvalidOptionValueException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOptionValueException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="includeDefaultMessage">if set to <c>true</c> a default message will be prefixed to the error message specified, which 
        /// will be something similar to "Invalid value &lt;value&gt; for option &lt;optionName&gt;: ".</param>
        public InvalidOptionValueException(string message, bool includeDefaultMessage)
            : base(message)
        {
            mIncludeDefaultMessage = includeDefaultMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOptionValueException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public InvalidOptionValueException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOptionValueException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"></see> is zero (0). </exception>
        /// <exception cref="T:System.ArgumentNullException">The info parameter is null. </exception>
        protected InvalidOptionValueException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The info parameter is a null reference (Nothing in Visual Basic). </exception>
        /// <PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter"/></PermissionSet>
        [SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            base.GetObjectData(info, context);
            info.AddValue("mIncludeDefaultMessage", mIncludeDefaultMessage);
        }

        /// <summary>
        /// Gets a value indicating whether the default message will be included in the error list supplied by <see cref="CommandLineParser.Errors"/>.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if the default message is included in the error list supplied by <see cref="CommandLineParser.Errors"/>; otherwise, <c>false</c>.
        /// </value>
        public bool InlcudeDefaultMessage
        {
            get { return mIncludeDefaultMessage; }
        }

        private bool mIncludeDefaultMessage = true;
    }
}
