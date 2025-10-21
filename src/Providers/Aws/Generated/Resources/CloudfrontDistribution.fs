namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> = { assignments: ResizeArray<aws.CloudfrontDistribution.CloudfrontDistributionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution">aws_cloudfront_distribution</a>.
    /// </summary>
    type CloudfrontDistributionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontDistributionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontDistributionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CloudfrontDistributionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontDistributionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// default_cache_behavior block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#default_cache_behavior-1">CloudfrontDistribution#default_cache_behavior</a>
        /// </summary>
        [<CustomOperation "default_cache_behavior">]
        member _.DefaultCacheBehavior(state: CloudfrontDistributionState<Missing, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: aws.CloudfrontDistribution.CloudfrontDistributionDefaultCacheBehavior) : CloudfrontDistributionState<Present, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.DefaultCacheBehavior <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<Present, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#enabled-1">CloudfrontDistribution#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudfrontDistributionState<'DefaultCacheBehavior, Missing, 'Origin, 'Restrictions, 'ViewerCertificate>, value: bool) : CloudfrontDistributionState<'DefaultCacheBehavior, Present, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<'DefaultCacheBehavior, Present, 'Origin, 'Restrictions, 'ViewerCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#enabled-1">CloudfrontDistribution#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CloudfrontDistributionState<'DefaultCacheBehavior, Missing, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, Present, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<'DefaultCacheBehavior, Present, 'Origin, 'Restrictions, 'ViewerCertificate>)

        /// <summary>
        /// origin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin-1">CloudfrontDistribution#origin</a> Accepts: aws.IResolvable | aws.CloudfrontDistribution.CloudfrontDistributionOrigin[]
        /// </summary>
        [<CustomOperation "origin">]
        member _.Origin(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, Missing, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, Present, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Origin <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, Present, 'Restrictions, 'ViewerCertificate>)

        /// <summary>
        /// restrictions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#restrictions-1">CloudfrontDistribution#restrictions</a>
        /// </summary>
        [<CustomOperation "restrictions">]
        member _.Restrictions(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, Missing, 'ViewerCertificate>, value: aws.CloudfrontDistribution.CloudfrontDistributionRestrictions) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, Present, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Restrictions <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, Present, 'ViewerCertificate>)

        /// <summary>
        /// viewer_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#viewer_certificate-1">CloudfrontDistribution#viewer_certificate</a>
        /// </summary>
        [<CustomOperation "viewer_certificate">]
        member _.ViewerCertificate(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, Missing>, value: aws.CloudfrontDistribution.CloudfrontDistributionViewerCertificate) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, Present> =
            state.assignments.Add(fun config -> config.ViewerCertificate <- value)
            ({ assignments = state.assignments } : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#aliases-1">CloudfrontDistribution#aliases</a>.
        /// </summary>
        [<CustomOperation "aliases">]
        member _.Aliases(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: seq<string>) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Aliases <- (value |> Seq.toArray))
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#comment-1">CloudfrontDistribution#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#continuous_deployment_policy_id-1">CloudfrontDistribution#continuous_deployment_policy_id</a>.
        /// </summary>
        [<CustomOperation "continuous_deployment_policy_id">]
        member _.ContinuousDeploymentPolicyId(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.ContinuousDeploymentPolicyId <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// custom_error_response block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#custom_error_response-1">CloudfrontDistribution#custom_error_response</a> Accepts: aws.IResolvable | aws.CloudfrontDistribution.CloudfrontDistributionCustomErrorResponse[]
        /// </summary>
        [<CustomOperation "custom_error_response">]
        member _.CustomErrorResponse(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.CustomErrorResponse <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#default_root_object-1">CloudfrontDistribution#default_root_object</a>.
        /// </summary>
        [<CustomOperation "default_root_object">]
        member _.DefaultRootObject(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.DefaultRootObject <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#http_version-1">CloudfrontDistribution#http_version</a>.
        /// </summary>
        [<CustomOperation "http_version">]
        member _.HttpVersion(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.HttpVersion <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#id-1">CloudfrontDistribution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#is_ipv6_enabled-1">CloudfrontDistribution#is_ipv6_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_ipv6_enabled">]
        member _.IsIpv6Enabled(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: bool) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.IsIpv6Enabled <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#is_ipv6_enabled-1">CloudfrontDistribution#is_ipv6_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_ipv6_enabled">]
        member _.IsIpv6Enabled(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.IsIpv6Enabled <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// logging_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#logging_config-1">CloudfrontDistribution#logging_config</a>
        /// </summary>
        [<CustomOperation "logging_config">]
        member _.LoggingConfig(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: aws.CloudfrontDistribution.CloudfrontDistributionLoggingConfig) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.LoggingConfig <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// ordered_cache_behavior block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#ordered_cache_behavior-1">CloudfrontDistribution#ordered_cache_behavior</a> Accepts: aws.IResolvable | aws.CloudfrontDistribution.CloudfrontDistributionOrderedCacheBehavior[]
        /// </summary>
        [<CustomOperation "ordered_cache_behavior">]
        member _.OrderedCacheBehavior(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.OrderedCacheBehavior <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// origin_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_group-1">CloudfrontDistribution#origin_group</a> Accepts: aws.IResolvable | aws.CloudfrontDistribution.CloudfrontDistributionOriginGroup[]
        /// </summary>
        [<CustomOperation "origin_group">]
        member _.OriginGroup(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.OriginGroup <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#price_class-1">CloudfrontDistribution#price_class</a>.
        /// </summary>
        [<CustomOperation "price_class">]
        member _.PriceClass(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.PriceClass <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#retain_on_delete-1">CloudfrontDistribution#retain_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_on_delete">]
        member _.RetainOnDelete(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: bool) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.RetainOnDelete <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#retain_on_delete-1">CloudfrontDistribution#retain_on_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "retain_on_delete">]
        member _.RetainOnDelete(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.RetainOnDelete <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#staging-1">CloudfrontDistribution#staging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "staging">]
        member _.Staging(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: bool) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Staging <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#staging-1">CloudfrontDistribution#staging</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "staging">]
        member _.Staging(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Staging <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#tags-1">CloudfrontDistribution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: seq<string * string>) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#tags_all-1">CloudfrontDistribution#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: seq<string * string>) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#wait_for_deployment-1">CloudfrontDistribution#wait_for_deployment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_deployment">]
        member _.WaitForDeployment(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: bool) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.WaitForDeployment <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#wait_for_deployment-1">CloudfrontDistribution#wait_for_deployment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_deployment">]
        member _.WaitForDeployment(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: HashiCorp.Cdktf.IResolvable) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.WaitForDeployment <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#web_acl_id-1">CloudfrontDistribution#web_acl_id</a>.
        /// </summary>
        [<CustomOperation "web_acl_id">]
        member _.WebAclId(state: CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>, value: string) : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate> =
            state.assignments.Add(fun config -> config.WebAclId <- value)
            state : CloudfrontDistributionState<'DefaultCacheBehavior, 'Enabled, 'Origin, 'Restrictions, 'ViewerCertificate>

        member _.Run(state: CloudfrontDistributionState<Present, Present, Present, Present, Present>) : aws.CloudfrontDistribution.CloudfrontDistribution =
            let config = aws.CloudfrontDistribution.CloudfrontDistributionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontDistribution.CloudfrontDistribution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontDistribution: missing required arguments. Must call: default_cache_behavior, enabled, origin, restrictions, viewer_certificate.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontDistributionState<_, _, _, _, _>) : aws.CloudfrontDistribution.CloudfrontDistribution =
            Unchecked.defaultof<aws.CloudfrontDistribution.CloudfrontDistribution>
