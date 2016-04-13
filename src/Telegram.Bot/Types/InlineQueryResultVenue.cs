﻿using Newtonsoft.Json;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the venue.
    /// </summary>
    /// <remarks>
    /// This will only work in Telegram versions released after 9 April, 2016. Older clients will ignore them.
    /// </remarks>
    [JsonObject(MemberSerialization.OptIn)]
    public class InlineQueryResultVenue : InlineQueryResult
    {
        /// <summary>
        /// Title of the result
        /// </summary>
        [JsonProperty("title", Required = Required.Always)]
        public new string Title { get; set; }

        /// <summary>
        /// Latitude of the location in degrees
        /// </summary>
        [JsonProperty("latitude", Required = Required.Always)]
        public float Latitude { get; set; }

        /// <summary>
        /// Longitude of the location in degrees
        /// </summary>
        [JsonProperty("longitude", Required = Required.Always)]
        public float Longitude { get; set; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty("address", Required = Required.Always)]
        public string Address { get; set; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue if known
        /// </summary>
        [JsonProperty("foursquare_id", Required = Required.Default)]
        public string FoursquareId { get; set; }
        
        /// <summary>
        /// Optional. Content of the message to be sent instead of the audio
        /// </summary>
        [JsonProperty("input_message_content", Required = Required.Default)]
        public InputMessageContent InputMessageContent { get; set; }

        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        [JsonProperty("thumb_width", Required = Required.Default)]
        public string ThumbWidth { get; set; }
        
        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        [JsonProperty("thumb_height", Required = Required.Default)]
        public string ThumbHeight { get; set; }
        
        [JsonIgnore]
        public new string MessageText { get; set; }

        [JsonIgnore]
        public new ParseMode ParseMode { get; set; }

        [JsonIgnore]
        public new bool DisableWebPagePreview { get; set; }
    }
}
