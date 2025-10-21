namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsResourcegroupstaggingapiResourcesState = { assignments: ResizeArray<aws.DataAwsResourcegroupstaggingapiResources.DataAwsResourcegroupstaggingapiResourcesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources">aws_resourcegroupstaggingapi_resources</a>.
    /// </summary>
    type DataAwsResourcegroupstaggingapiResourcesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsResourcegroupstaggingapiResourcesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsResourcegroupstaggingapiResourcesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#exclude_compliant_resources-1">DataAwsResourcegroupstaggingapiResources#exclude_compliant_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_compliant_resources">]
        member _.ExcludeCompliantResources(state: DataAwsResourcegroupstaggingapiResourcesState, value: bool) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.ExcludeCompliantResources <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#exclude_compliant_resources-1">DataAwsResourcegroupstaggingapiResources#exclude_compliant_resources</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "exclude_compliant_resources">]
        member _.ExcludeCompliantResources(state: DataAwsResourcegroupstaggingapiResourcesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.ExcludeCompliantResources <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#id-1">DataAwsResourcegroupstaggingapiResources#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsResourcegroupstaggingapiResourcesState, value: string) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#include_compliance_details-1">DataAwsResourcegroupstaggingapiResources#include_compliance_details</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_compliance_details">]
        member _.IncludeComplianceDetails(state: DataAwsResourcegroupstaggingapiResourcesState, value: bool) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.IncludeComplianceDetails <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#include_compliance_details-1">DataAwsResourcegroupstaggingapiResources#include_compliance_details</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_compliance_details">]
        member _.IncludeComplianceDetails(state: DataAwsResourcegroupstaggingapiResourcesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.IncludeComplianceDetails <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#resource_arn_list-1">DataAwsResourcegroupstaggingapiResources#resource_arn_list</a>.
        /// </summary>
        [<CustomOperation "resource_arn_list">]
        member _.ResourceArnList(state: DataAwsResourcegroupstaggingapiResourcesState, value: seq<string>) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.ResourceArnList <- (value |> Seq.toArray))
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#resource_type_filters-1">DataAwsResourcegroupstaggingapiResources#resource_type_filters</a>.
        /// </summary>
        [<CustomOperation "resource_type_filters">]
        member _.ResourceTypeFilters(state: DataAwsResourcegroupstaggingapiResourcesState, value: seq<string>) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.ResourceTypeFilters <- (value |> Seq.toArray))
            state : DataAwsResourcegroupstaggingapiResourcesState

        /// <summary>
        /// tag_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourcegroupstaggingapi_resources#tag_filter-1">DataAwsResourcegroupstaggingapiResources#tag_filter</a> Accepts: aws.IResolvable | aws.DataAwsResourcegroupstaggingapiResources.DataAwsResourcegroupstaggingapiResourcesTagFilter[]
        /// </summary>
        [<CustomOperation "tag_filter">]
        member _.TagFilter(state: DataAwsResourcegroupstaggingapiResourcesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsResourcegroupstaggingapiResourcesState =
            state.assignments.Add(fun config -> config.TagFilter <- value)
            state : DataAwsResourcegroupstaggingapiResourcesState

        member _.Run(state: DataAwsResourcegroupstaggingapiResourcesState) : aws.DataAwsResourcegroupstaggingapiResources.DataAwsResourcegroupstaggingapiResources =
            let config = aws.DataAwsResourcegroupstaggingapiResources.DataAwsResourcegroupstaggingapiResourcesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsResourcegroupstaggingapiResources.DataAwsResourcegroupstaggingapiResources(StackContext.get (), logicalId, config)
