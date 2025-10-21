namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MediaStoreContainerPolicyState<'ContainerName, 'Policy> = { assignments: ResizeArray<aws.MediaStoreContainerPolicy.MediaStoreContainerPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container_policy">aws_media_store_container_policy</a>.
    /// </summary>
    type MediaStoreContainerPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : MediaStoreContainerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MediaStoreContainerPolicyState<Missing, Missing>)

        member _.Zero(()) : MediaStoreContainerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MediaStoreContainerPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container_policy#container_name-1">MediaStoreContainerPolicy#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: MediaStoreContainerPolicyState<Missing, 'Policy>, value: string) : MediaStoreContainerPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : MediaStoreContainerPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container_policy#policy-1">MediaStoreContainerPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: MediaStoreContainerPolicyState<'ContainerName, Missing>, value: string) : MediaStoreContainerPolicyState<'ContainerName, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : MediaStoreContainerPolicyState<'ContainerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_store_container_policy#id-1">MediaStoreContainerPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MediaStoreContainerPolicyState<'ContainerName, 'Policy>, value: string) : MediaStoreContainerPolicyState<'ContainerName, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MediaStoreContainerPolicyState<'ContainerName, 'Policy>

        member _.Run(state: MediaStoreContainerPolicyState<Present, Present>) : aws.MediaStoreContainerPolicy.MediaStoreContainerPolicy =
            let config = aws.MediaStoreContainerPolicy.MediaStoreContainerPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.MediaStoreContainerPolicy.MediaStoreContainerPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mediaStoreContainerPolicy: missing required arguments. Must call: container_name, policy.", 9999, IsError = true)>]
        member _.Run(_: MediaStoreContainerPolicyState<_, _>) : aws.MediaStoreContainerPolicy.MediaStoreContainerPolicy =
            Unchecked.defaultof<aws.MediaStoreContainerPolicy.MediaStoreContainerPolicy>
