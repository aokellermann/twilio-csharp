/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// VerificationAttemptResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Verify.V2
{

    public class VerificationAttemptResource : Resource
    {
        public sealed class ChannelsEnum : StringEnum
        {
            private ChannelsEnum(string value) : base(value) {}
            public ChannelsEnum() {}
            public static implicit operator ChannelsEnum(string value)
            {
                return new ChannelsEnum(value);
            }

            public static readonly ChannelsEnum Sms = new ChannelsEnum("sms");
            public static readonly ChannelsEnum Call = new ChannelsEnum("call");
            public static readonly ChannelsEnum Email = new ChannelsEnum("email");
            public static readonly ChannelsEnum Whatsapp = new ChannelsEnum("whatsapp");
        }

        public sealed class ConversionStatusEnum : StringEnum
        {
            private ConversionStatusEnum(string value) : base(value) {}
            public ConversionStatusEnum() {}
            public static implicit operator ConversionStatusEnum(string value)
            {
                return new ConversionStatusEnum(value);
            }

            public static readonly ConversionStatusEnum Converted = new ConversionStatusEnum("converted");
            public static readonly ConversionStatusEnum Unconverted = new ConversionStatusEnum("unconverted");
        }

        private static Request BuildReadRequest(ReadVerificationAttemptOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Attempts",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// List all the verification attempts for a given Account.
        /// </summary>
        /// <param name="options"> Read VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static ResourceSet<VerificationAttemptResource> Read(ReadVerificationAttemptOptions options,
                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
            return new ResourceSet<VerificationAttemptResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List all the verification attempts for a given Account.
        /// </summary>
        /// <param name="options"> Read VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VerificationAttemptResource>> ReadAsync(ReadVerificationAttemptOptions options,
                                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
            return new ResourceSet<VerificationAttemptResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List all the verification attempts for a given Account.
        /// </summary>
        /// <param name="dateCreatedAfter"> Filter verification attempts after this date </param>
        /// <param name="dateCreatedBefore"> Filter verification attempts befor this date </param>
        /// <param name="channelDataTo"> Destination of a verification </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static ResourceSet<VerificationAttemptResource> Read(DateTime? dateCreatedAfter = null,
                                                                    DateTime? dateCreatedBefore = null,
                                                                    string channelDataTo = null,
                                                                    int? pageSize = null,
                                                                    long? limit = null,
                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadVerificationAttemptOptions(){DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, ChannelDataTo = channelDataTo, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List all the verification attempts for a given Account.
        /// </summary>
        /// <param name="dateCreatedAfter"> Filter verification attempts after this date </param>
        /// <param name="dateCreatedBefore"> Filter verification attempts befor this date </param>
        /// <param name="channelDataTo"> Destination of a verification </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<VerificationAttemptResource>> ReadAsync(DateTime? dateCreatedAfter = null,
                                                                                                            DateTime? dateCreatedBefore = null,
                                                                                                            string channelDataTo = null,
                                                                                                            int? pageSize = null,
                                                                                                            long? limit = null,
                                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadVerificationAttemptOptions(){DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, ChannelDataTo = channelDataTo, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<VerificationAttemptResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<VerificationAttemptResource> NextPage(Page<VerificationAttemptResource> page,
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<VerificationAttemptResource> PreviousPage(Page<VerificationAttemptResource> page,
                                                                     ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<VerificationAttemptResource>.FromJson("attempts", response.Content);
        }

        private static Request BuildFetchRequest(FetchVerificationAttemptOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Attempts/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific verification attempt.
        /// </summary>
        /// <param name="options"> Fetch VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static VerificationAttemptResource Fetch(FetchVerificationAttemptOptions options,
                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific verification attempt.
        /// </summary>
        /// <param name="options"> Fetch VerificationAttempt parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptResource> FetchAsync(FetchVerificationAttemptOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific verification attempt.
        /// </summary>
        /// <param name="pathSid"> Verification Attempt Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttempt </returns>
        public static VerificationAttemptResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific verification attempt.
        /// </summary>
        /// <param name="pathSid"> Verification Attempt Sid. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttempt </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptResource> FetchAsync(string pathSid,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a VerificationAttemptResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VerificationAttemptResource object represented by the provided JSON </returns>
        public static VerificationAttemptResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<VerificationAttemptResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Verification Attempt
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The date this Attempt was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Attempt was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Status of a conversion
        /// </summary>
        [JsonProperty("conversion_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public VerificationAttemptResource.ConversionStatusEnum ConversionStatus { get; private set; }
        /// <summary>
        /// Channel used for the attempt
        /// </summary>
        [JsonProperty("channel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public VerificationAttemptResource.ChannelsEnum Channel { get; private set; }
        /// <summary>
        /// Object with the channel information for an attempt
        /// </summary>
        [JsonProperty("channel_data")]
        public object ChannelData { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private VerificationAttemptResource()
        {

        }
    }

}