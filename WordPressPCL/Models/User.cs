﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WordPressPCL.Models
{
    /// <summary>
    /// Type represents Entity User of WP REST API
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        /// <remarks>
        /// Read only
        /// Context: embed, view, edit
        /// </remarks>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
        /// <summary>
        /// Login name for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("username")]
        public string UserName { get; set; }
        /// <summary>
        /// Display name for the user.
        /// </summary>
        /// <remarks>
        /// Context: embed, view, edit
        /// </remarks>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// First name for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Last name for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// The email address for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// URL of the user.
        /// </summary>
        /// <remarks>Context: embed, view, edit</remarks>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Description of the user.
        /// </summary>
        /// <remarks>Context: embed, view, edit</remarks>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Author URL of the user.
        /// </summary>
        /// <remarks>
        /// Read only
        /// Context: embed, view, edit
        /// </remarks>
        [JsonProperty("link")]
        public string Link { get; set; }
        /// <summary>
        /// Locale for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("locale")]
        public string Locale { get; set; }
        /// <summary>
        /// The nickname for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("nickname",DefaultValueHandling =DefaultValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the user.
        /// </summary>
        /// <remarks>Context: embed, view, edit</remarks>
        [JsonProperty("slug")]
        public string Slug { get; set; }
        /// <summary>
        /// Registration date for the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("registered_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime RegisteredDate { get; set; }
        /// <summary>
        /// Roles assigned to the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }
        /// <summary>
        /// Password for the user (never included).
        /// </summary>
        /// <remarks>Context:</remarks>
        [JsonProperty("password")]
        public string Password { get; set; }
        /// <summary>
        /// All capabilities assigned to the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("capabilities")]
        public IEnumerable<object> Capabilities { get; set; }
        /// <summary>
        /// Any extra capabilities assigned to the user.
        /// </summary>
        /// <remarks>Context: edit</remarks>
        [JsonProperty("extra_capabilities")]
        public IEnumerable<object> ExtraCapabilities { get; set; }

        /// <summary>
        /// Avatar URLs for the user.
        /// </summary>
        /// <remarks>
        /// Read only
        /// Context: embed, view, edit
        /// </remarks>
        [JsonProperty("avatar_urls", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvatarURL AvatarUrls { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        /// <remarks>Context: view, edit</remarks>
        [JsonProperty("meta", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<object> Meta { get; set; }

        /// <summary>
        /// Links to related resources
        /// </summary>
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Links Links { get; set; }
    }

}
