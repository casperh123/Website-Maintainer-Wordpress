// <auto-generated/>
#pragma warning disable CS0618
using Enhance.Client.Models;
using Enhance.Client.Orgs.Item.Websites.Item.AccessTokens;
using Enhance.Client.Orgs.Item.Websites.Item.Apps;
using Enhance.Client.Orgs.Item.Websites.Item.Backups;
using Enhance.Client.Orgs.Item.Websites.Item.Cgroup_limits;
using Enhance.Client.Orgs.Item.Websites.Item.Crontab;
using Enhance.Client.Orgs.Item.Websites.Item.Domains;
using Enhance.Client.Orgs.Item.Websites.Item.Emails;
using Enhance.Client.Orgs.Item.Websites.Item.Fs_quota_limits;
using Enhance.Client.Orgs.Item.Websites.Item.Ftp;
using Enhance.Client.Orgs.Item.Websites.Item.Htaccess;
using Enhance.Client.Orgs.Item.Websites.Item.Metrics;
using Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs;
using Enhance.Client.Orgs.Item.Websites.Item.MysqlUsers;
using Enhance.Client.Orgs.Item.Websites.Item.Preview;
using Enhance.Client.Orgs.Item.Websites.Item.PushLive;
using Enhance.Client.Orgs.Item.Websites.Item.Server_domains;
using Enhance.Client.Orgs.Item.Websites.Item.Settings;
using Enhance.Client.Orgs.Item.Websites.Item.Ssh;
using Enhance.Client.Orgs.Item.Websites.Item.Status;
using Enhance.Client.Orgs.Item.Websites.Item.ValidateOperation;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Enhance.Client.Orgs.Item.Websites.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org_id}\websites\{website_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WithWebsite_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The accessTokens property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.AccessTokens.AccessTokensRequestBuilder AccessTokens
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.AccessTokens.AccessTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The apps property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Apps.AppsRequestBuilder Apps
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Apps.AppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The backups property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Backups.BackupsRequestBuilder Backups
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Backups.BackupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cgroup_limits property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Cgroup_limits.Cgroup_limitsRequestBuilder Cgroup_limits
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Cgroup_limits.Cgroup_limitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The crontab property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Crontab.CrontabRequestBuilder Crontab
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Crontab.CrontabRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domains property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Domains.DomainsRequestBuilder Domains
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Domains.DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emails property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Emails.EmailsRequestBuilder Emails
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Emails.EmailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fs_quota_limits property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Fs_quota_limits.Fs_quota_limitsRequestBuilder Fs_quota_limits
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Fs_quota_limits.Fs_quota_limitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ftp property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Ftp.FtpRequestBuilder Ftp
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Ftp.FtpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Endpoints for managing .htaccess rewrites</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Htaccess.HtaccessRequestBuilder Htaccess
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Htaccess.HtaccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The metrics property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Metrics.MetricsRequestBuilder Metrics
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Metrics.MetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mysqlDbs property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder MysqlDbs
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.MysqlDbs.MysqlDbsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mysqlUsers property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.MysqlUsers.MysqlUsersRequestBuilder MysqlUsers
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.MysqlUsers.MysqlUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The preview property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Preview.PreviewRequestBuilder Preview
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Preview.PreviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushLive property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.PushLive.PushLiveRequestBuilder PushLive
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.PushLive.PushLiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The server_domains property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Server_domains.Server_domainsRequestBuilder Server_domains
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Server_domains.Server_domainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssh property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Ssh.SshRequestBuilder Ssh
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Ssh.SshRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.Status.StatusRequestBuilder Status
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.Status.StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validateOperation property</summary>
        public global::Enhance.Client.Orgs.Item.Websites.Item.ValidateOperation.ValidateOperationRequestBuilder ValidateOperation
        {
            get => new global::Enhance.Client.Orgs.Item.Websites.Item.ValidateOperation.ValidateOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWebsite_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}{?force*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWebsite_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org_id}/websites/{website_id}{?force*}", rawUrl)
        {
        }
        /// <summary>
        /// Mark a website as deleted, which does not remove its data, or force remove all its data.For removing all data and metadata belonging to a website (including DB records), pass the `force=true` query parameter. This can only be done by a privileged MO member. In this case, all data is wiped, so use carefully.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder.WithWebsite_ItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder.WithWebsite_ItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns detailed information about a single website.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Models.Website"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Enhance.Client.Models.Website?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Enhance.Client.Models.Website> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Enhance.Client.Models.Website>(requestInfo, global::Enhance.Client.Models.Website.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the website.It may be used to enable or disable a specific version of PHP for a website, in which case a corresponding `PhpCd` instance is installed or uninstalled on the same server of the website. When enabling the website PHP it is also possible to specify whether the SSH daemon will need to be enabled in the `PhpCd` service at startup, via the `ssh` boolean flag. Moreover, if PHP is already enabled for a website, it is possible to enable or disable its SSH by only specifying the `ssh` flag.The endpoint is also responsible for assigning tags to a website. Note that the input overwrites all existing tags, so when adding a new tag, the `tags` property also has to include existing tags that are to be kept.Only a parent organization or MO admin may suspend websites.The website may be moved to another subscription, if that subscription has enough quota to accommodate the new website, unless the MO is performing the action, in which case they may move any website off a subscription or to a subscription that doesn&apos;t necessary have quota left.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PatchAsync(global::Enhance.Client.Models.UpdateWebsite body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PatchAsync(global::Enhance.Client.Models.UpdateWebsite body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Mark a website as deleted, which does not remove its data, or force remove all its data.For removing all data and metadata belonging to a website (including DB records), pass the `force=true` query parameter. This can only be done by a privileged MO member. In this case, all data is wiped, so use carefully.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder.WithWebsite_ItemRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder.WithWebsite_ItemRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns detailed information about a single website.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates the website.It may be used to enable or disable a specific version of PHP for a website, in which case a corresponding `PhpCd` instance is installed or uninstalled on the same server of the website. When enabling the website PHP it is also possible to specify whether the SSH daemon will need to be enabled in the `PhpCd` service at startup, via the `ssh` boolean flag. Moreover, if PHP is already enabled for a website, it is possible to enable or disable its SSH by only specifying the `ssh` flag.The endpoint is also responsible for assigning tags to a website. Note that the input overwrites all existing tags, so when adding a new tag, the `tags` property also has to include existing tags that are to be kept.Only a parent organization or MO admin may suspend websites.The website may be moved to another subscription, if that subscription has enough quota to accommodate the new website, unless the MO is performing the action, in which case they may move any website off a subscription or to a subscription that doesn&apos;t necessary have quota left.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Enhance.Client.Models.UpdateWebsite body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Enhance.Client.Models.UpdateWebsite body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Mark a website as deleted, which does not remove its data, or force remove all its data.For removing all data and metadata belonging to a website (including DB records), pass the `force=true` query parameter. This can only be done by a privileged MO member. In this case, all data is wiped, so use carefully.Session holder must be at least a `SuperAdmin` in this org or a parent org.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithWebsite_ItemRequestBuilderDeleteQueryParameters 
        {
            [QueryParameter("force")]
            public bool? Force { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithWebsite_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Enhance.Client.Orgs.Item.Websites.Item.WithWebsite_ItemRequestBuilder.WithWebsite_ItemRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithWebsite_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WithWebsite_ItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
