namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SyntheticsGroupAssociationState<'CanaryArn, 'GroupName> = { assignments: ResizeArray<aws.SyntheticsGroupAssociation.SyntheticsGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group_association">aws_synthetics_group_association</a>.
    /// </summary>
    type SyntheticsGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SyntheticsGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SyntheticsGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : SyntheticsGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SyntheticsGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group_association#canary_arn-1">SyntheticsGroupAssociation#canary_arn</a>.
        /// </summary>
        [<CustomOperation "canary_arn">]
        member _.CanaryArn(state: SyntheticsGroupAssociationState<Missing, 'GroupName>, value: string) : SyntheticsGroupAssociationState<Present, 'GroupName> =
            state.assignments.Add(fun config -> config.CanaryArn <- value)
            ({ assignments = state.assignments } : SyntheticsGroupAssociationState<Present, 'GroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group_association#group_name-1">SyntheticsGroupAssociation#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: SyntheticsGroupAssociationState<'CanaryArn, Missing>, value: string) : SyntheticsGroupAssociationState<'CanaryArn, Present> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : SyntheticsGroupAssociationState<'CanaryArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group_association#id-1">SyntheticsGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SyntheticsGroupAssociationState<'CanaryArn, 'GroupName>, value: string) : SyntheticsGroupAssociationState<'CanaryArn, 'GroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SyntheticsGroupAssociationState<'CanaryArn, 'GroupName>

        member _.Run(state: SyntheticsGroupAssociationState<Present, Present>) : aws.SyntheticsGroupAssociation.SyntheticsGroupAssociation =
            let config = aws.SyntheticsGroupAssociation.SyntheticsGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.SyntheticsGroupAssociation.SyntheticsGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.syntheticsGroupAssociation: missing required arguments. Must call: canary_arn, group_name.", 9999, IsError = true)>]
        member _.Run(_: SyntheticsGroupAssociationState<_, _>) : aws.SyntheticsGroupAssociation.SyntheticsGroupAssociation =
            Unchecked.defaultof<aws.SyntheticsGroupAssociation.SyntheticsGroupAssociation>
