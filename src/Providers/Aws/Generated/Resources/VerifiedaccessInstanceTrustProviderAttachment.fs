namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, 'VerifiedaccessTrustProviderId> = { assignments: ResizeArray<aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_trust_provider_attachment">aws_verifiedaccess_instance_trust_provider_attachment</a>.
    /// </summary>
    type VerifiedaccessInstanceTrustProviderAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessInstanceTrustProviderAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessInstanceTrustProviderAttachmentState<Missing, Missing>)

        member _.Zero(()) : VerifiedaccessInstanceTrustProviderAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessInstanceTrustProviderAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_trust_provider_attachment#verifiedaccess_instance_id-1">VerifiedaccessInstanceTrustProviderAttachment#verifiedaccess_instance_id</a>.
        /// </summary>
        [<CustomOperation "verifiedaccess_instance_id">]
        member _.VerifiedaccessInstanceId(state: VerifiedaccessInstanceTrustProviderAttachmentState<Missing, 'VerifiedaccessTrustProviderId>, value: string) : VerifiedaccessInstanceTrustProviderAttachmentState<Present, 'VerifiedaccessTrustProviderId> =
            state.assignments.Add(fun config -> config.VerifiedaccessInstanceId <- value)
            ({ assignments = state.assignments } : VerifiedaccessInstanceTrustProviderAttachmentState<Present, 'VerifiedaccessTrustProviderId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_trust_provider_attachment#verifiedaccess_trust_provider_id-1">VerifiedaccessInstanceTrustProviderAttachment#verifiedaccess_trust_provider_id</a>.
        /// </summary>
        [<CustomOperation "verifiedaccess_trust_provider_id">]
        member _.VerifiedaccessTrustProviderId(state: VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, Missing>, value: string) : VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, Present> =
            state.assignments.Add(fun config -> config.VerifiedaccessTrustProviderId <- value)
            ({ assignments = state.assignments } : VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance_trust_provider_attachment#id-1">VerifiedaccessInstanceTrustProviderAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, 'VerifiedaccessTrustProviderId>, value: string) : VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, 'VerifiedaccessTrustProviderId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessInstanceTrustProviderAttachmentState<'VerifiedaccessInstanceId, 'VerifiedaccessTrustProviderId>

        member _.Run(state: VerifiedaccessInstanceTrustProviderAttachmentState<Present, Present>) : aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachment =
            let config = aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedaccessInstanceTrustProviderAttachment: missing required arguments. Must call: verifiedaccess_instance_id, verifiedaccess_trust_provider_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedaccessInstanceTrustProviderAttachmentState<_, _>) : aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachment =
            Unchecked.defaultof<aws.VerifiedaccessInstanceTrustProviderAttachment.VerifiedaccessInstanceTrustProviderAttachment>
