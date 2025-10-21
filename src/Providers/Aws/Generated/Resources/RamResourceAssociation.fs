namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RamResourceAssociationState<'ResourceArn, 'ResourceShareArn> = { assignments: ResizeArray<aws.RamResourceAssociation.RamResourceAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_association">aws_ram_resource_association</a>.
    /// </summary>
    type RamResourceAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RamResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RamResourceAssociationState<Missing, Missing>)

        member _.Zero(()) : RamResourceAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RamResourceAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_association#resource_arn-1">RamResourceAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: RamResourceAssociationState<Missing, 'ResourceShareArn>, value: string) : RamResourceAssociationState<Present, 'ResourceShareArn> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : RamResourceAssociationState<Present, 'ResourceShareArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_association#resource_share_arn-1">RamResourceAssociation#resource_share_arn</a>.
        /// </summary>
        [<CustomOperation "resource_share_arn">]
        member _.ResourceShareArn(state: RamResourceAssociationState<'ResourceArn, Missing>, value: string) : RamResourceAssociationState<'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.ResourceShareArn <- value)
            ({ assignments = state.assignments } : RamResourceAssociationState<'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_association#id-1">RamResourceAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RamResourceAssociationState<'ResourceArn, 'ResourceShareArn>, value: string) : RamResourceAssociationState<'ResourceArn, 'ResourceShareArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RamResourceAssociationState<'ResourceArn, 'ResourceShareArn>

        member _.Run(state: RamResourceAssociationState<Present, Present>) : aws.RamResourceAssociation.RamResourceAssociation =
            let config = aws.RamResourceAssociation.RamResourceAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RamResourceAssociation.RamResourceAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ramResourceAssociation: missing required arguments. Must call: resource_arn, resource_share_arn.", 9999, IsError = true)>]
        member _.Run(_: RamResourceAssociationState<_, _>) : aws.RamResourceAssociation.RamResourceAssociation =
            Unchecked.defaultof<aws.RamResourceAssociation.RamResourceAssociation>
