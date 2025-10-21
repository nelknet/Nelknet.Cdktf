namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourcegroupsResourceState<'GroupArn, 'ResourceArn> = { assignments: ResizeArray<aws.ResourcegroupsResource.ResourcegroupsResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_resource">aws_resourcegroups_resource</a>.
    /// </summary>
    type ResourcegroupsResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourcegroupsResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcegroupsResourceState<Missing, Missing>)

        member _.Zero(()) : ResourcegroupsResourceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcegroupsResourceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_resource#group_arn-1">ResourcegroupsResource#group_arn</a>.
        /// </summary>
        [<CustomOperation "group_arn">]
        member _.GroupArn(state: ResourcegroupsResourceState<Missing, 'ResourceArn>, value: string) : ResourcegroupsResourceState<Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.GroupArn <- value)
            ({ assignments = state.assignments } : ResourcegroupsResourceState<Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_resource#resource_arn-1">ResourcegroupsResource#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: ResourcegroupsResourceState<'GroupArn, Missing>, value: string) : ResourcegroupsResourceState<'GroupArn, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : ResourcegroupsResourceState<'GroupArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_resource#id-1">ResourcegroupsResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourcegroupsResourceState<'GroupArn, 'ResourceArn>, value: string) : ResourcegroupsResourceState<'GroupArn, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourcegroupsResourceState<'GroupArn, 'ResourceArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourcegroups_resource#timeouts-1">ResourcegroupsResource#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourcegroupsResourceState<'GroupArn, 'ResourceArn>, value: aws.ResourcegroupsResource.ResourcegroupsResourceTimeouts) : ResourcegroupsResourceState<'GroupArn, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourcegroupsResourceState<'GroupArn, 'ResourceArn>

        member _.Run(state: ResourcegroupsResourceState<Present, Present>) : aws.ResourcegroupsResource.ResourcegroupsResource =
            let config = aws.ResourcegroupsResource.ResourcegroupsResourceConfig()
            for setter in state.assignments do
                setter config
            aws.ResourcegroupsResource.ResourcegroupsResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.resourcegroupsResource: missing required arguments. Must call: group_arn, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: ResourcegroupsResourceState<_, _>) : aws.ResourcegroupsResource.ResourcegroupsResource =
            Unchecked.defaultof<aws.ResourcegroupsResource.ResourcegroupsResource>
