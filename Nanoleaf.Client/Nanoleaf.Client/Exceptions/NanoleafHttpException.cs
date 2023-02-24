using System;

namespace Nanoleaf.Client.Exceptions
{
    /// <inheritdoc/>
    public class NanoleafHttpException : Exception
    {
        /// <inheritdoc/>
        public NanoleafHttpException(string message) : base(message)
        {

        }
    }
}