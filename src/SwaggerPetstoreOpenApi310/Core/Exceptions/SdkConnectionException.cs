using System;

namespace SwaggerPetstoreOpenApi310.Core.Exceptions;

public class SdkConnectionException(string message, Exception? innerException = null)
    : SdkException(message, innerException);
