namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> = { assignments: ResizeArray<aws.XraySamplingRule.XraySamplingRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule">aws_xray_sampling_rule</a>.
    /// </summary>
    type XraySamplingRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : XraySamplingRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : XraySamplingRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : XraySamplingRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : XraySamplingRuleState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#fixed_rate-1">XraySamplingRule#fixed_rate</a>.
        /// </summary>
        [<CustomOperation "fixed_rate">]
        member _.FixedRate(state: XraySamplingRuleState<Missing, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: double) : XraySamplingRuleState<Present, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.FixedRate <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<Present, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#host-1">XraySamplingRule#host</a>.
        /// </summary>
        [<CustomOperation "host">]
        member _.Host(state: XraySamplingRuleState<'FixedRate, Missing, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, Present, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.Host <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, Present, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#http_method-1">XraySamplingRule#http_method</a>.
        /// </summary>
        [<CustomOperation "http_method">]
        member _.HttpMethod(state: XraySamplingRuleState<'FixedRate, 'Host, Missing, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, Present, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.HttpMethod <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, Present, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#priority-1">XraySamplingRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, Missing, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: double) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, Present, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, Present, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#reservoir_size-1">XraySamplingRule#reservoir_size</a>.
        /// </summary>
        [<CustomOperation "reservoir_size">]
        member _.ReservoirSize(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, Missing, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: double) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, Present, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.ReservoirSize <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, Present, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#resource_arn-1">XraySamplingRule#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, Missing, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, Present, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, Present, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#service_name-1">XraySamplingRule#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, Missing, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, Present, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, Present, 'ServiceType, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#service_type-1">XraySamplingRule#service_type</a>.
        /// </summary>
        [<CustomOperation "service_type">]
        member _.ServiceType(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, Missing, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, Present, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.ServiceType <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, Present, 'UrlPath, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#url_path-1">XraySamplingRule#url_path</a>.
        /// </summary>
        [<CustomOperation "url_path">]
        member _.UrlPath(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, Missing, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, Present, 'Version> =
            state.assignments.Add(fun config -> config.UrlPath <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#version-1">XraySamplingRule#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, Missing>, value: double) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#attributes-1">XraySamplingRule#attributes</a>.
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: seq<string * string>) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.Attributes <- dict value)
            state : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#id-1">XraySamplingRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#rule_name-1">XraySamplingRule#rule_name</a>.
        /// </summary>
        [<CustomOperation "rule_name">]
        member _.RuleName(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: string) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.RuleName <- value)
            state : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#tags-1">XraySamplingRule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: seq<string * string>) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_sampling_rule#tags_all-1">XraySamplingRule#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>, value: seq<string * string>) : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : XraySamplingRuleState<'FixedRate, 'Host, 'HttpMethod, 'Priority, 'ReservoirSize, 'ResourceArn, 'ServiceName, 'ServiceType, 'UrlPath, 'Version>

        member _.Run(state: XraySamplingRuleState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : aws.XraySamplingRule.XraySamplingRule =
            let config = aws.XraySamplingRule.XraySamplingRuleConfig()
            for setter in state.assignments do
                setter config
            aws.XraySamplingRule.XraySamplingRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.xraySamplingRule: missing required arguments. Must call: fixed_rate, host, http_method, priority, reservoir_size, resource_arn, service_name, service_type, url_path, version.", 9999, IsError = true)>]
        member _.Run(_: XraySamplingRuleState<_, _, _, _, _, _, _, _, _, _>) : aws.XraySamplingRule.XraySamplingRule =
            Unchecked.defaultof<aws.XraySamplingRule.XraySamplingRule>
