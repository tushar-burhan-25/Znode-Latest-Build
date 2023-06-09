﻿using System;
using System.Text;
using Znode.Engine.Services;

namespace Znode.Engine.QuickBook
{
    public class AuthenticationHelper : IDisposable
    {
        #region Private Variables

        private bool isDisposed;

        #endregion Private Variables

        #region Constructor

        ~AuthenticationHelper()
        {
            if (!isDisposed)
                Dispose();
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Implementation of IDisposable
        /// </summary>
        public void Dispose() => isDisposed = true;

        #endregion Public Methods

        #region Public Static Methods

        //Encrypted tickets can be in database and validate tickets from database.
        /// <summary>
        /// Validate the ticket against the default ticket set
        /// </summary>
        /// <param name="ticket">Token sent in request header</param>
        /// <returns>Validation result</returns>
        public static bool ValidateTicket(string ticket)
        => string.Equals(ticket, QuickBookConstants.ValidationToken);

        /// <summary>
        /// Encodes plain text into Base 64 string
        /// </summary>
        /// <param name="plainText">Text to be encoded</param>
        /// <returns>Base64 encoded string</returns>
        public static string Base64Encode(string plainText)
        => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));

        /// <summary>
        /// Decodes Base64 encoded string to plain text
        /// </summary>
        /// <param name="base64EncodedData">Base64 encoded string</param>
        /// <returns>Plain string</returns>
        public static string Base64Decode(string base64EncodedData)
        => Encoding.UTF8.GetString(Convert.FromBase64String(base64EncodedData));

        /// <summary>
        /// Gives user id for the user which is required to get data from Znode.
        /// </summary>
        /// <returns>User id from ZNode for accessing data</returns>
        public static int GetQBZnodeAdminUserId()
        => ((new UserService())).
             GetUserByUsername(QuickBookConstants.QBAdminZnodeUsername, QuickBookConstants.QBAdminZnodePortalId).
             UserId;

        #endregion Public Static Methods
    }
}