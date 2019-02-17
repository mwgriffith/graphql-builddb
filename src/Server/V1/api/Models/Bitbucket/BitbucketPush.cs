﻿
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Server.V1.api.Models.Bitbucket;
//
//    var bitbucketPush = BitbucketPush.FromJson(jsonString);

namespace Server.V1.api.Models.Bitbucket
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BitbucketPush
    {
        [JsonProperty("push")]
        public Push Push { get; set; }

        [JsonProperty("actor")]
        public Actor Actor { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }
    }

    public partial class Actor
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("links")]
        public ActorLinks Links { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public partial class ActorLinks
    {
        [JsonProperty("self")]
        public Avatar Self { get; set; }

        [JsonProperty("html")]
        public Avatar Html { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class Push
    {
        [JsonProperty("changes")]
        public Change[] Changes { get; set; }
    }

    public partial class Change
    {
        [JsonProperty("forced")]
        public bool Forced { get; set; }

        [JsonProperty("old")]
        public New Old { get; set; }

        [JsonProperty("links")]
        public ChangeLinks Links { get; set; }

        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("commits")]
        public Commit[] Commits { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("new")]
        public New New { get; set; }
    }

    public partial class Commit
    {
        [JsonProperty("rendered")]
        public Rendered Rendered { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("links")]
        public CommitLinks Links { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("parents")]
        public Parent[] Parents { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public Actor User { get; set; }
    }

    public partial class CommitLinks
    {
        [JsonProperty("self")]
        public Avatar Self { get; set; }

        [JsonProperty("comments")]
        public Avatar Comments { get; set; }

        [JsonProperty("patch")]
        public Avatar Patch { get; set; }

        [JsonProperty("html")]
        public Avatar Html { get; set; }

        [JsonProperty("diff")]
        public Avatar Diff { get; set; }

        [JsonProperty("approve")]
        public Avatar Approve { get; set; }

        [JsonProperty("statuses")]
        public Avatar Statuses { get; set; }
    }

    public partial class Parent
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public ParentLinks Links { get; set; }
    }

    public partial class ParentLinks
    {
        [JsonProperty("self")]
        public Avatar Self { get; set; }

        [JsonProperty("html")]
        public Avatar Html { get; set; }
    }

    public partial class Rendered
    {
    }

    public partial class Summary
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("markup")]
        public string Markup { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ChangeLinks
    {
        [JsonProperty("commits")]
        public Avatar Commits { get; set; }

        [JsonProperty("html")]
        public Avatar Html { get; set; }

        [JsonProperty("diff")]
        public Avatar Diff { get; set; }
    }

    public partial class New
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public NewLinks Links { get; set; }

        [JsonProperty("default_merge_strategy")]
        public string DefaultMergeStrategy { get; set; }

        [JsonProperty("merge_strategies")]
        public string[] MergeStrategies { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }
    }

    public partial class NewLinks
    {
        [JsonProperty("commits")]
        public Avatar Commits { get; set; }

        [JsonProperty("self")]
        public Avatar Self { get; set; }

        [JsonProperty("html")]
        public Avatar Html { get; set; }
    }

    public partial class Target
    {
        [JsonProperty("rendered")]
        public Rendered Rendered { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("links")]
        public ParentLinks Links { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("parents")]
        public Parent[] Parents { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Repository
    {
        [JsonProperty("scm")]
        public string Scm { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public ActorLinks Links { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("owner")]
        public Actor Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public partial class BitbucketPush
    {
        public static BitbucketPush FromJson(string json) => JsonConvert.DeserializeObject<BitbucketPush>(json, Server.V1.api.Models.Bitbucket.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BitbucketPush self) => JsonConvert.SerializeObject(self, Server.V1.api.Models.Bitbucket.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
