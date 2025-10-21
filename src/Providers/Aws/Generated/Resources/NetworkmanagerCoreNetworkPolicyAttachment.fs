namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument> = { assignments: ResizeArray<aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network_policy_attachment">aws_networkmanager_core_network_policy_attachment</a>.
    /// </summary>
    type NetworkmanagerCoreNetworkPolicyAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkmanagerCoreNetworkPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCoreNetworkPolicyAttachmentState<Missing, Missing>)

        member _.Zero(()) : NetworkmanagerCoreNetworkPolicyAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkmanagerCoreNetworkPolicyAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network_policy_attachment#core_network_id-1">NetworkmanagerCoreNetworkPolicyAttachment#core_network_id</a>.
        /// </summary>
        [<CustomOperation "core_network_id">]
        member _.CoreNetworkId(state: NetworkmanagerCoreNetworkPolicyAttachmentState<Missing, 'PolicyDocument>, value: string) : NetworkmanagerCoreNetworkPolicyAttachmentState<Present, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.CoreNetworkId <- value)
            ({ assignments = state.assignments } : NetworkmanagerCoreNetworkPolicyAttachmentState<Present, 'PolicyDocument>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network_policy_attachment#policy_document-1">NetworkmanagerCoreNetworkPolicyAttachment#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, Missing>, value: string) : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, Present> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network_policy_attachment#id-1">NetworkmanagerCoreNetworkPolicyAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument>, value: string) : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_core_network_policy_attachment#timeouts-1">NetworkmanagerCoreNetworkPolicyAttachment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument>, value: aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachmentTimeouts) : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkmanagerCoreNetworkPolicyAttachmentState<'CoreNetworkId, 'PolicyDocument>

        member _.Run(state: NetworkmanagerCoreNetworkPolicyAttachmentState<Present, Present>) : aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachment =
            let config = aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkmanagerCoreNetworkPolicyAttachment: missing required arguments. Must call: core_network_id, policy_document.", 9999, IsError = true)>]
        member _.Run(_: NetworkmanagerCoreNetworkPolicyAttachmentState<_, _>) : aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachment =
            Unchecked.defaultof<aws.NetworkmanagerCoreNetworkPolicyAttachment.NetworkmanagerCoreNetworkPolicyAttachment>
