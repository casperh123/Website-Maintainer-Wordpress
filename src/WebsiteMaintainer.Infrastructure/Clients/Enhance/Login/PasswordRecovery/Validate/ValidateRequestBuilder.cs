// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Login.PasswordRecovery.Validate
{
    /// <summary>
    /// Builds and executes requests for operations under \login\password-recovery\validate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ValidateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValidateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/login/password-recovery/validate?secret={secret}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValidateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/login/password-recovery/validate?secret={secret}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the obfuscated email address belonging to the user initiating the password recovery if the secret is correct and hasn&apos;t expired yet.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.ValidatedPasswordRecovery"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.ValidatedPasswordRecovery?> PostAsync(Action<RequestConfiguration<global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder.ValidateRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.ValidatedPasswordRecovery> PostAsync(Action<RequestConfiguration<global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder.ValidateRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.ValidatedPasswordRecovery>(requestInfo, global::Enhance.Client.Models.ValidatedPasswordRecovery.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the obfuscated email address belonging to the user initiating the password recovery if the secret is correct and hasn&apos;t expired yet.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder.ValidateRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder.ValidateRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the obfuscated email address belonging to the user initiating the password recovery if the secret is correct and hasn&apos;t expired yet.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ValidateRequestBuilderPostQueryParameters 
        {
            /// <summary>The secret key for the password recovery.</summary>
            [QueryParameter("secret")]
            public Guid? Secret { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ValidateRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Enhance.Client.Login.PasswordRecovery.Validate.ValidateRequestBuilder.ValidateRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
