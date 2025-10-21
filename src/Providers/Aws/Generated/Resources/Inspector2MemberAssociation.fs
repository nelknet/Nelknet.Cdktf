namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Inspector2MemberAssociationState<'AccountId> = { assignments: ResizeArray<aws.Inspector2MemberAssociation.Inspector2MemberAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_member_association">aws_inspector2_member_association</a>.
    /// </summary>
    type Inspector2MemberAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Inspector2MemberAssociationState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2MemberAssociationState<Missing>)

        member _.Zero(()) : Inspector2MemberAssociationState<Missing> =
            ({ assignments = ResizeArray() } : Inspector2MemberAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_member_association#account_id-1">Inspector2MemberAssociation#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: Inspector2MemberAssociationState<Missing>, value: string) : Inspector2MemberAssociationState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : Inspector2MemberAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_member_association#id-1">Inspector2MemberAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Inspector2MemberAssociationState<'AccountId>, value: string) : Inspector2MemberAssociationState<'AccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Inspector2MemberAssociationState<'AccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_member_association#timeouts-1">Inspector2MemberAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Inspector2MemberAssociationState<'AccountId>, value: aws.Inspector2MemberAssociation.Inspector2MemberAssociationTimeouts) : Inspector2MemberAssociationState<'AccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Inspector2MemberAssociationState<'AccountId>

        member _.Run(state: Inspector2MemberAssociationState<Present>) : aws.Inspector2MemberAssociation.Inspector2MemberAssociation =
            let config = aws.Inspector2MemberAssociation.Inspector2MemberAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.Inspector2MemberAssociation.Inspector2MemberAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspector2MemberAssociation: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: Inspector2MemberAssociationState<_>) : aws.Inspector2MemberAssociation.Inspector2MemberAssociation =
            Unchecked.defaultof<aws.Inspector2MemberAssociation.Inspector2MemberAssociation>
