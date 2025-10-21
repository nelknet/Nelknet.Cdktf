namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> = { assignments: ResizeArray<aws.FmsPolicy.FmsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy">aws_fms_policy</a>.
    /// </summary>
    type FmsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : FmsPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FmsPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : FmsPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FmsPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#exclude_resource_tags-1">FmsPolicy#exclude_resource_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_resource_tags">]
        member _.ExcludeResourceTags(state: FmsPolicyState<Missing, 'Name, 'SecurityServicePolicyData>, value: bool) : FmsPolicyState<Present, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ExcludeResourceTags <- value)
            ({ assignments = state.assignments } : FmsPolicyState<Present, 'Name, 'SecurityServicePolicyData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#exclude_resource_tags-1">FmsPolicy#exclude_resource_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_resource_tags">]
        member _.ExcludeResourceTags(state: FmsPolicyState<Missing, 'Name, 'SecurityServicePolicyData>, value: HashiCorp.Cdktf.IResolvable) : FmsPolicyState<Present, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ExcludeResourceTags <- value)
            ({ assignments = state.assignments } : FmsPolicyState<Present, 'Name, 'SecurityServicePolicyData>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#name-1">FmsPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FmsPolicyState<'ExcludeResourceTags, Missing, 'SecurityServicePolicyData>, value: string) : FmsPolicyState<'ExcludeResourceTags, Present, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FmsPolicyState<'ExcludeResourceTags, Present, 'SecurityServicePolicyData>)

        /// <summary>
        /// security_service_policy_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#security_service_policy_data-1">FmsPolicy#security_service_policy_data</a>
        /// </summary>
        [<CustomOperation "security_service_policy_data">]
        member _.SecurityServicePolicyData(state: FmsPolicyState<'ExcludeResourceTags, 'Name, Missing>, value: aws.FmsPolicy.FmsPolicySecurityServicePolicyData) : FmsPolicyState<'ExcludeResourceTags, 'Name, Present> =
            state.assignments.Add(fun config -> config.SecurityServicePolicyData <- value)
            ({ assignments = state.assignments } : FmsPolicyState<'ExcludeResourceTags, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#delete_all_policy_resources-1">FmsPolicy#delete_all_policy_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_all_policy_resources">]
        member _.DeleteAllPolicyResources(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: bool) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.DeleteAllPolicyResources <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#delete_all_policy_resources-1">FmsPolicy#delete_all_policy_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_all_policy_resources">]
        member _.DeleteAllPolicyResources(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: HashiCorp.Cdktf.IResolvable) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.DeleteAllPolicyResources <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#delete_unused_fm_managed_resources-1">FmsPolicy#delete_unused_fm_managed_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_unused_fm_managed_resources">]
        member _.DeleteUnusedFmManagedResources(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: bool) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.DeleteUnusedFmManagedResources <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#delete_unused_fm_managed_resources-1">FmsPolicy#delete_unused_fm_managed_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_unused_fm_managed_resources">]
        member _.DeleteUnusedFmManagedResources(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: HashiCorp.Cdktf.IResolvable) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.DeleteUnusedFmManagedResources <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#description-1">FmsPolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: string) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// exclude_map block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#exclude_map-1">FmsPolicy#exclude_map</a>
        /// </summary>
        [<CustomOperation "exclude_map">]
        member _.ExcludeMap(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: aws.FmsPolicy.FmsPolicyExcludeMap) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ExcludeMap <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#id-1">FmsPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: string) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// include_map block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#include_map-1">FmsPolicy#include_map</a>
        /// </summary>
        [<CustomOperation "include_map">]
        member _.IncludeMap(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: aws.FmsPolicy.FmsPolicyIncludeMap) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.IncludeMap <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#remediation_enabled-1">FmsPolicy#remediation_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "remediation_enabled">]
        member _.RemediationEnabled(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: bool) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.RemediationEnabled <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#remediation_enabled-1">FmsPolicy#remediation_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "remediation_enabled">]
        member _.RemediationEnabled(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: HashiCorp.Cdktf.IResolvable) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.RemediationEnabled <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#resource_set_ids-1">FmsPolicy#resource_set_ids</a>.
        /// </summary>
        [<CustomOperation "resource_set_ids">]
        member _.ResourceSetIds(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: seq<string>) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ResourceSetIds <- (value |> Seq.toArray))
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#resource_tags-1">FmsPolicy#resource_tags</a>.
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: seq<string * string>) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ResourceTags <- dict value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#resource_type-1">FmsPolicy#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: string) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#resource_type_list-1">FmsPolicy#resource_type_list</a>.
        /// </summary>
        [<CustomOperation "resource_type_list">]
        member _.ResourceTypeList(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: seq<string>) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.ResourceTypeList <- (value |> Seq.toArray))
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#tags-1">FmsPolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: seq<string * string>) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#tags_all-1">FmsPolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>, value: seq<string * string>) : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FmsPolicyState<'ExcludeResourceTags, 'Name, 'SecurityServicePolicyData>

        member _.Run(state: FmsPolicyState<Present, Present, Present>) : aws.FmsPolicy.FmsPolicy =
            let config = aws.FmsPolicy.FmsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.FmsPolicy.FmsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fmsPolicy: missing required arguments. Must call: exclude_resource_tags, name, security_service_policy_data.", 9999, IsError = true)>]
        member _.Run(_: FmsPolicyState<_, _, _>) : aws.FmsPolicy.FmsPolicy =
            Unchecked.defaultof<aws.FmsPolicy.FmsPolicy>
