namespace Nanoleaf.Client.Exceptions
{
    /// <inheritdoc/>
    public class NanoleafUnauthorizedException : NanoleafHttpException
    {
        /// <inheritdoc/>
        public NanoleafUnauthorizedException(string message) : base(message)
        {

        }
    }
}