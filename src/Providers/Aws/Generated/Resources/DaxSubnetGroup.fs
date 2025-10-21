namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DaxSubnetGroupState<'Name, 'SubnetIds> = { assignments: ResizeArray<aws.DaxSubnetGroup.DaxSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_subnet_group">aws_dax_subnet_group</a>.
    /// </summary>
    type DaxSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DaxSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DaxSubnetGroupState<Missing, Missing>)

        member _.Zero(()) : DaxSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DaxSubnetGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_subnet_group#name-1">DaxSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DaxSubnetGroupState<Missing, 'SubnetIds>, value: string) : DaxSubnetGroupState<Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DaxSubnetGroupState<Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_subnet_group#subnet_ids-1">DaxSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DaxSubnetGroupState<'Name, Missing>, value: seq<string>) : DaxSubnetGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DaxSubnetGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_subnet_group#description-1">DaxSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DaxSubnetGroupState<'Name, 'SubnetIds>, value: string) : DaxSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DaxSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dax_subnet_group#id-1">DaxSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DaxSubnetGroupState<'Name, 'SubnetIds>, value: string) : DaxSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DaxSubnetGroupState<'Name, 'SubnetIds>

        member _.Run(state: DaxSubnetGroupState<Present, Present>) : aws.DaxSubnetGroup.DaxSubnetGroup =
            let config = aws.DaxSubnetGroup.DaxSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DaxSubnetGroup.DaxSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.daxSubnetGroup: missing required arguments. Must call: name, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DaxSubnetGroupState<_, _>) : aws.DaxSubnetGroup.DaxSubnetGroup =
            Unchecked.defaultof<aws.DaxSubnetGroup.DaxSubnetGroup>
