﻿namespace Framework.Api.Base.Errors
{
    using System;
    using System.Net;

    /*
     * An error factory class that returns the interface rather than the concrete type
     */
    public static class ErrorFactory
    {
        /*
         * Create an error indicating a server error
         */
        public static ApiError CreateApiError(string errorCode, string userMessage)
        {
            return new ApiErrorImpl(errorCode, userMessage);
        }

        /*
         * Create a server error from a caught exception
         */
        public static ApiError CreateApiError(string errorCode, string userMessage, Exception inner)
        {
            return new ApiErrorImpl(errorCode, userMessage, inner);
        }

        /*
         * Create an error indicating a client problem
         */
        public static ClientError CreateClientError(HttpStatusCode statusCode, string errorCode, string userMessage)
        {
            return new ClientErrorImpl(statusCode, errorCode, userMessage);
        }

        /*
         * Create an error indicating a client problem with additional context
         */
        public static ClientError CreateClientErrorWithContext(
            HttpStatusCode statusCode,
            string errorCode,
            string userMessage,
            string logContext)
        {
            var error = new ClientErrorImpl(statusCode, errorCode, userMessage);
            error.LogContext = logContext;
            return error;
        }

        /*
         * Create a 401 error with the reason
         */
        public static ClientError Create401Error(string reason)
        {
            var error = new ClientErrorImpl(
                    HttpStatusCode.Unauthorized,
                    BaseErrorCodes.UnauthorizedRequest,
                    "Missing, invalid or expired access token");
            error.LogContext = reason;
            return error;
        }
    }
}