namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevopsguruResourceCollectionState<'Type> = { assignments: ResizeArray<aws.DevopsguruResourceCollection.DevopsguruResourceCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection">aws_devopsguru_resource_collection</a>.
    /// </summary>
    type DevopsguruResourceCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevopsguruResourceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DevopsguruResourceCollectionState<Missing>)

        member _.Zero(()) : DevopsguruResourceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DevopsguruResourceCollectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#type-1">DevopsguruResourceCollection#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DevopsguruResourceCollectionState<Missing>, value: string) : DevopsguruResourceCollectionState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DevopsguruResourceCollectionState<Present>)

        /// <summary>
        /// cloudformation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#cloudformation-1">DevopsguruResourceCollection#cloudformation</a> Accepts: aws.IResolvable | aws.DevopsguruResourceCollection.DevopsguruResourceCollectionCloudformation[]
        /// </summary>
        [<CustomOperation "cloudformation">]
        member _.Cloudformation(state: DevopsguruResourceCollectionState<'Type>, value: HashiCorp.Cdktf.IResolvable) : DevopsguruResourceCollectionState<'Type> =
            state.assignments.Add(fun config -> config.Cloudformation <- value)
            state : DevopsguruResourceCollectionState<'Type>

        /// <summary>
        /// tags block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_resource_collection#tags-1">DevopsguruResourceCollection#tags</a> Accepts: aws.IResolvable | aws.DevopsguruResourceCollection.DevopsguruResourceCollectionTags[]
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevopsguruResourceCollectionState<'Type>, value: HashiCorp.Cdktf.IResolvable) : DevopsguruResourceCollectionState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- value)
            state : DevopsguruResourceCollectionState<'Type>

        member _.Run(state: DevopsguruResourceCollectionState<Present>) : aws.DevopsguruResourceCollection.DevopsguruResourceCollection =
            let config = aws.DevopsguruResourceCollection.DevopsguruResourceCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.DevopsguruResourceCollection.DevopsguruResourceCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devopsguruResourceCollection: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: DevopsguruResourceCollectionState<_>) : aws.DevopsguruResourceCollection.DevopsguruResourceCollection =
            Unchecked.defaultof<aws.DevopsguruResourceCollection.DevopsguruResourceCollection>
