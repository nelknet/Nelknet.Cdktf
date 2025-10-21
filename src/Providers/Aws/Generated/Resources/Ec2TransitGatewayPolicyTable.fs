namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2TransitGatewayPolicyTableState<'TransitGatewayId> = { assignments: ResizeArray<aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table">aws_ec2_transit_gateway_policy_table</a>.
    /// </summary>
    type Ec2TransitGatewayPolicyTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2TransitGatewayPolicyTableState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPolicyTableState<Missing>)

        member _.Zero(()) : Ec2TransitGatewayPolicyTableState<Missing> =
            ({ assignments = ResizeArray() } : Ec2TransitGatewayPolicyTableState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table#transit_gateway_id-1">Ec2TransitGatewayPolicyTable#transit_gateway_id</a>.
        /// </summary>
        [<CustomOperation "transit_gateway_id">]
        member _.TransitGatewayId(state: Ec2TransitGatewayPolicyTableState<Missing>, value: string) : Ec2TransitGatewayPolicyTableState<Present> =
            state.assignments.Add(fun config -> config.TransitGatewayId <- value)
            ({ assignments = state.assignments } : Ec2TransitGatewayPolicyTableState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table#id-1">Ec2TransitGatewayPolicyTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2TransitGatewayPolicyTableState<'TransitGatewayId>, value: string) : Ec2TransitGatewayPolicyTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2TransitGatewayPolicyTableState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table#tags-1">Ec2TransitGatewayPolicyTable#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2TransitGatewayPolicyTableState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayPolicyTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2TransitGatewayPolicyTableState<'TransitGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_transit_gateway_policy_table#tags_all-1">Ec2TransitGatewayPolicyTable#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2TransitGatewayPolicyTableState<'TransitGatewayId>, value: seq<string * string>) : Ec2TransitGatewayPolicyTableState<'TransitGatewayId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2TransitGatewayPolicyTableState<'TransitGatewayId>

        member _.Run(state: Ec2TransitGatewayPolicyTableState<Present>) : aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTable =
            let config = aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTableConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2TransitGatewayPolicyTable: missing required arguments. Must call: transit_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2TransitGatewayPolicyTableState<_>) : aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTable =
            Unchecked.defaultof<aws.Ec2TransitGatewayPolicyTable.Ec2TransitGatewayPolicyTable>
