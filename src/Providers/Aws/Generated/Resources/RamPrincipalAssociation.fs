namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RamPrincipalAssociationState<'Principal, 'ResourceShareArn> = { assignments: ResizeArray<aws.RamPrincipalAssociation.RamPrincipalAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_principal_association">aws_ram_principal_association</a>.
    /// </summary>
    type RamPrincipalAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RamPrincipalAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RamPrincipalAssociationState<Missing, Missing>)

        member _.Zero(()) : RamPrincipalAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RamPrincipalAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_principal_association#principal-1">RamPrincipalAssociation#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: RamPrincipalAssociationState<Missing, 'ResourceShareArn>, value: string) : RamPrincipalAssociationState<Present, 'ResourceShareArn> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : RamPrincipalAssociationState<Present, 'ResourceShareArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_principal_association#resource_share_arn-1">RamPrincipalAssociation#resource_share_arn</a>.
        /// </summary>
        [<CustomOperation "resource_share_arn">]
        member _.ResourceShareArn(state: RamPrincipalAssociationState<'Principal, Missing>, value: string) : RamPrincipalAssociationState<'Principal, Present> =
            state.assignments.Add(fun config -> config.ResourceShareArn <- value)
            ({ assignments = state.assignments } : RamPrincipalAssociationState<'Principal, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_principal_association#id-1">RamPrincipalAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RamPrincipalAssociationState<'Principal, 'ResourceShareArn>, value: string) : RamPrincipalAssociationState<'Principal, 'ResourceShareArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RamPrincipalAssociationState<'Principal, 'ResourceShareArn>

        member _.Run(state: RamPrincipalAssociationState<Present, Present>) : aws.RamPrincipalAssociation.RamPrincipalAssociation =
            let config = aws.RamPrincipalAssociation.RamPrincipalAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RamPrincipalAssociation.RamPrincipalAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ramPrincipalAssociation: missing required arguments. Must call: principal, resource_share_arn.", 9999, IsError = true)>]
        member _.Run(_: RamPrincipalAssociationState<_, _>) : aws.RamPrincipalAssociation.RamPrincipalAssociation =
            Unchecked.defaultof<aws.RamPrincipalAssociation.RamPrincipalAssociation>
