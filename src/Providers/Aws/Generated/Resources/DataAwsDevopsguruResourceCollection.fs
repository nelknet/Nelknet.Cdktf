namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDevopsguruResourceCollectionState<'Type> = { assignments: ResizeArray<aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_resource_collection">aws_devopsguru_resource_collection</a>.
    /// </summary>
    type DataAwsDevopsguruResourceCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDevopsguruResourceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDevopsguruResourceCollectionState<Missing>)

        member _.Zero(()) : DataAwsDevopsguruResourceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDevopsguruResourceCollectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_resource_collection#type-1">DataAwsDevopsguruResourceCollection#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsDevopsguruResourceCollectionState<Missing>, value: string) : DataAwsDevopsguruResourceCollectionState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAwsDevopsguruResourceCollectionState<Present>)

        /// <summary>
        /// cloudformation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_resource_collection#cloudformation-1">DataAwsDevopsguruResourceCollection#cloudformation</a> Accepts: aws.IResolvable | aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollectionCloudformation[]
        /// </summary>
        [<CustomOperation "cloudformation">]
        member _.Cloudformation(state: DataAwsDevopsguruResourceCollectionState<'Type>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDevopsguruResourceCollectionState<'Type> =
            state.assignments.Add(fun config -> config.Cloudformation <- value)
            state : DataAwsDevopsguruResourceCollectionState<'Type>

        /// <summary>
        /// tags block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_resource_collection#tags-1">DataAwsDevopsguruResourceCollection#tags</a> Accepts: aws.IResolvable | aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollectionTags[]
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDevopsguruResourceCollectionState<'Type>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDevopsguruResourceCollectionState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- value)
            state : DataAwsDevopsguruResourceCollectionState<'Type>

        member _.Run(state: DataAwsDevopsguruResourceCollectionState<Present>) : aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollection =
            let config = aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDevopsguruResourceCollection: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDevopsguruResourceCollectionState<_>) : aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollection =
            Unchecked.defaultof<aws.DataAwsDevopsguruResourceCollection.DataAwsDevopsguruResourceCollection>
