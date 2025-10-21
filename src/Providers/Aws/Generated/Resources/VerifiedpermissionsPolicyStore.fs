namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedpermissionsPolicyStoreState = { assignments: ResizeArray<aws.VerifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store">aws_verifiedpermissions_policy_store</a>.
    /// </summary>
    type VerifiedpermissionsPolicyStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedpermissionsPolicyStoreState =
            { assignments = ResizeArray() }

        member _.Zero(()) : VerifiedpermissionsPolicyStoreState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store#description-1">VerifiedpermissionsPolicyStore#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedpermissionsPolicyStoreState, value: string) : VerifiedpermissionsPolicyStoreState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedpermissionsPolicyStoreState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store#tags-1">VerifiedpermissionsPolicyStore#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VerifiedpermissionsPolicyStoreState, value: seq<string * string>) : VerifiedpermissionsPolicyStoreState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VerifiedpermissionsPolicyStoreState

        /// <summary>
        /// validation_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy_store#validation_settings-1">VerifiedpermissionsPolicyStore#validation_settings</a> Accepts: aws.IResolvable | aws.VerifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStoreValidationSettings[]
        /// </summary>
        [<CustomOperation "validation_settings">]
        member _.ValidationSettings(state: VerifiedpermissionsPolicyStoreState, value: HashiCorp.Cdktf.IResolvable) : VerifiedpermissionsPolicyStoreState =
            state.assignments.Add(fun config -> config.ValidationSettings <- value)
            state : VerifiedpermissionsPolicyStoreState

        member _.Run(state: VerifiedpermissionsPolicyStoreState) : aws.VerifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStore =
            let config = aws.VerifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStoreConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedpermissionsPolicyStore.VerifiedpermissionsPolicyStore(StackContext.get (), logicalId, config)
