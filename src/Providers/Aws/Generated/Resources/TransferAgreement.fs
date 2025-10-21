namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> = { assignments: ResizeArray<aws.TransferAgreement.TransferAgreementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement">aws_transfer_agreement</a>.
    /// </summary>
    type TransferAgreementBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferAgreementState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferAgreementState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : TransferAgreementState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferAgreementState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#access_role-1">TransferAgreement#access_role</a>.
        /// </summary>
        [<CustomOperation "access_role">]
        member _.AccessRole(state: TransferAgreementState<Missing, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: string) : TransferAgreementState<Present, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.AccessRole <- value)
            ({ assignments = state.assignments } : TransferAgreementState<Present, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#base_directory-1">TransferAgreement#base_directory</a>.
        /// </summary>
        [<CustomOperation "base_directory">]
        member _.BaseDirectory(state: TransferAgreementState<'AccessRole, Missing, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: string) : TransferAgreementState<'AccessRole, Present, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.BaseDirectory <- value)
            ({ assignments = state.assignments } : TransferAgreementState<'AccessRole, Present, 'LocalProfileId, 'PartnerProfileId, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#local_profile_id-1">TransferAgreement#local_profile_id</a>.
        /// </summary>
        [<CustomOperation "local_profile_id">]
        member _.LocalProfileId(state: TransferAgreementState<'AccessRole, 'BaseDirectory, Missing, 'PartnerProfileId, 'ServerId>, value: string) : TransferAgreementState<'AccessRole, 'BaseDirectory, Present, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.LocalProfileId <- value)
            ({ assignments = state.assignments } : TransferAgreementState<'AccessRole, 'BaseDirectory, Present, 'PartnerProfileId, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#partner_profile_id-1">TransferAgreement#partner_profile_id</a>.
        /// </summary>
        [<CustomOperation "partner_profile_id">]
        member _.PartnerProfileId(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, Missing, 'ServerId>, value: string) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, Present, 'ServerId> =
            state.assignments.Add(fun config -> config.PartnerProfileId <- value)
            ({ assignments = state.assignments } : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#server_id-1">TransferAgreement#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, Missing>, value: string) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#description-1">TransferAgreement#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: string) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#id-1">TransferAgreement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: string) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#tags-1">TransferAgreement#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: seq<string * string>) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_agreement#tags_all-1">TransferAgreement#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>, value: seq<string * string>) : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferAgreementState<'AccessRole, 'BaseDirectory, 'LocalProfileId, 'PartnerProfileId, 'ServerId>

        member _.Run(state: TransferAgreementState<Present, Present, Present, Present, Present>) : aws.TransferAgreement.TransferAgreement =
            let config = aws.TransferAgreement.TransferAgreementConfig()
            for setter in state.assignments do
                setter config
            aws.TransferAgreement.TransferAgreement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferAgreement: missing required arguments. Must call: access_role, base_directory, local_profile_id, partner_profile_id, server_id.", 9999, IsError = true)>]
        member _.Run(_: TransferAgreementState<_, _, _, _, _>) : aws.TransferAgreement.TransferAgreement =
            Unchecked.defaultof<aws.TransferAgreement.TransferAgreement>
