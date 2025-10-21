namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsResourceTagsState<'ResourceId> = { assignments: ResizeArray<aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTagsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_resource_tags">aws_organizations_resource_tags</a>.
    /// </summary>
    type DataAwsOrganizationsResourceTagsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsResourceTagsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsResourceTagsState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsResourceTagsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsResourceTagsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_resource_tags#resource_id-1">DataAwsOrganizationsResourceTags#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: DataAwsOrganizationsResourceTagsState<Missing>, value: string) : DataAwsOrganizationsResourceTagsState<Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsResourceTagsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_resource_tags#id-1">DataAwsOrganizationsResourceTags#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsResourceTagsState<'ResourceId>, value: string) : DataAwsOrganizationsResourceTagsState<'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsResourceTagsState<'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_resource_tags#tags-1">DataAwsOrganizationsResourceTags#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsOrganizationsResourceTagsState<'ResourceId>, value: seq<string * string>) : DataAwsOrganizationsResourceTagsState<'ResourceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsOrganizationsResourceTagsState<'ResourceId>

        member _.Run(state: DataAwsOrganizationsResourceTagsState<Present>) : aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTags =
            let config = aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTagsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTags(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsResourceTags: missing required arguments. Must call: resource_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsResourceTagsState<_>) : aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTags =
            Unchecked.defaultof<aws.DataAwsOrganizationsResourceTags.DataAwsOrganizationsResourceTags>
