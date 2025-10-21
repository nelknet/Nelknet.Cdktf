namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> = { assignments: ResizeArray<aws.LightsailDistribution.LightsailDistributionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution">aws_lightsail_distribution</a>.
    /// </summary>
    type LightsailDistributionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDistributionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDistributionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LightsailDistributionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDistributionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The bundle ID to use for the distribution. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#bundle_id-1">LightsailDistribution#bundle_id</a>
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: LightsailDistributionState<Missing, 'DefaultCacheBehavior, 'Name, 'Origin>, value: string) : LightsailDistributionState<Present, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            ({ assignments = state.assignments } : LightsailDistributionState<Present, 'DefaultCacheBehavior, 'Name, 'Origin>)

        /// <summary>
        /// default_cache_behavior block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#default_cache_behavior-1">LightsailDistribution#default_cache_behavior</a>
        /// </summary>
        [<CustomOperation "default_cache_behavior">]
        member _.DefaultCacheBehavior(state: LightsailDistributionState<'BundleId, Missing, 'Name, 'Origin>, value: aws.LightsailDistribution.LightsailDistributionDefaultCacheBehavior) : LightsailDistributionState<'BundleId, Present, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.DefaultCacheBehavior <- value)
            ({ assignments = state.assignments } : LightsailDistributionState<'BundleId, Present, 'Name, 'Origin>)

        /// <summary>
        /// The name of the distribution. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#name-1">LightsailDistribution#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, Missing, 'Origin>, value: string) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, Present, 'Origin> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, Present, 'Origin>)

        /// <summary>
        /// origin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#origin-1">LightsailDistribution#origin</a>
        /// </summary>
        [<CustomOperation "origin">]
        member _.Origin(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, Missing>, value: aws.LightsailDistribution.LightsailDistributionOrigin) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, Present> =
            state.assignments.Add(fun config -> config.Origin <- value)
            ({ assignments = state.assignments } : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, Present>)

        /// <summary>
        /// cache_behavior block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cache_behavior-1">LightsailDistribution#cache_behavior</a> Accepts: aws.IResolvable | aws.LightsailDistribution.LightsailDistributionCacheBehavior[]
        /// </summary>
        [<CustomOperation "cache_behavior">]
        member _.CacheBehavior(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: HashiCorp.Cdktf.IResolvable) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.CacheBehavior <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// cache_behavior_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cache_behavior_settings-1">LightsailDistribution#cache_behavior_settings</a>
        /// </summary>
        [<CustomOperation "cache_behavior_settings">]
        member _.CacheBehaviorSettings(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettings) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.CacheBehaviorSettings <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// The name of the SSL/TLS certificate attached to the distribution, if any. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#certificate_name-1">LightsailDistribution#certificate_name</a>
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: string) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#id-1">LightsailDistribution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: string) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// The IP address type of the distribution. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#ip_address_type-1">LightsailDistribution#ip_address_type</a>
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: string) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// Indicates whether the distribution is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#is_enabled-1">LightsailDistribution#is_enabled</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: bool) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// Indicates whether the distribution is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#is_enabled-1">LightsailDistribution#is_enabled</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_enabled">]
        member _.IsEnabled(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: HashiCorp.Cdktf.IResolvable) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.IsEnabled <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#tags-1">LightsailDistribution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: seq<string * string>) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#tags_all-1">LightsailDistribution#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: seq<string * string>) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#timeouts-1">LightsailDistribution#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>, value: aws.LightsailDistribution.LightsailDistributionTimeouts) : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LightsailDistributionState<'BundleId, 'DefaultCacheBehavior, 'Name, 'Origin>

        member _.Run(state: LightsailDistributionState<Present, Present, Present, Present>) : aws.LightsailDistribution.LightsailDistribution =
            let config = aws.LightsailDistribution.LightsailDistributionConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDistribution.LightsailDistribution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDistribution: missing required arguments. Must call: bundle_id, default_cache_behavior, name, origin.", 9999, IsError = true)>]
        member _.Run(_: LightsailDistributionState<_, _, _, _>) : aws.LightsailDistribution.LightsailDistribution =
            Unchecked.defaultof<aws.LightsailDistribution.LightsailDistribution>
