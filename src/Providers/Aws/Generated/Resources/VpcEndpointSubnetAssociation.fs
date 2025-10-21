namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId> = { assignments: ResizeArray<aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_subnet_association">aws_vpc_endpoint_subnet_association</a>.
    /// </summary>
    type VpcEndpointSubnetAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointSubnetAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointSubnetAssociationState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointSubnetAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointSubnetAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_subnet_association#subnet_id-1">VpcEndpointSubnetAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: VpcEndpointSubnetAssociationState<Missing, 'VpcEndpointId>, value: string) : VpcEndpointSubnetAssociationState<Present, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : VpcEndpointSubnetAssociationState<Present, 'VpcEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_subnet_association#vpc_endpoint_id-1">VpcEndpointSubnetAssociation#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointSubnetAssociationState<'SubnetId, Missing>, value: string) : VpcEndpointSubnetAssociationState<'SubnetId, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointSubnetAssociationState<'SubnetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_subnet_association#id-1">VpcEndpointSubnetAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId>, value: string) : VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_subnet_association#timeouts-1">VpcEndpointSubnetAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId>, value: aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociationTimeouts) : VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcEndpointSubnetAssociationState<'SubnetId, 'VpcEndpointId>

        member _.Run(state: VpcEndpointSubnetAssociationState<Present, Present>) : aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociation =
            let config = aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointSubnetAssociation: missing required arguments. Must call: subnet_id, vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointSubnetAssociationState<_, _>) : aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociation =
            Unchecked.defaultof<aws.VpcEndpointSubnetAssociation.VpcEndpointSubnetAssociation>
