namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftSubnetGroupState<'Name, 'SubnetIds> = { assignments: ResizeArray<aws.RedshiftSubnetGroup.RedshiftSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group">aws_redshift_subnet_group</a>.
    /// </summary>
    type RedshiftSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSubnetGroupState<Missing, Missing>)

        member _.Zero(()) : RedshiftSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftSubnetGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#name-1">RedshiftSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedshiftSubnetGroupState<Missing, 'SubnetIds>, value: string) : RedshiftSubnetGroupState<Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedshiftSubnetGroupState<Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#subnet_ids-1">RedshiftSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: RedshiftSubnetGroupState<'Name, Missing>, value: seq<string>) : RedshiftSubnetGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : RedshiftSubnetGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#description-1">RedshiftSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftSubnetGroupState<'Name, 'SubnetIds>, value: string) : RedshiftSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RedshiftSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#id-1">RedshiftSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftSubnetGroupState<'Name, 'SubnetIds>, value: string) : RedshiftSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#tags-1">RedshiftSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftSubnetGroupState<'Name, 'SubnetIds>, value: seq<string * string>) : RedshiftSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_subnet_group#tags_all-1">RedshiftSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftSubnetGroupState<'Name, 'SubnetIds>, value: seq<string * string>) : RedshiftSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftSubnetGroupState<'Name, 'SubnetIds>

        member _.Run(state: RedshiftSubnetGroupState<Present, Present>) : aws.RedshiftSubnetGroup.RedshiftSubnetGroup =
            let config = aws.RedshiftSubnetGroup.RedshiftSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftSubnetGroup.RedshiftSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftSubnetGroup: missing required arguments. Must call: name, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: RedshiftSubnetGroupState<_, _>) : aws.RedshiftSubnetGroup.RedshiftSubnetGroup =
            Unchecked.defaultof<aws.RedshiftSubnetGroup.RedshiftSubnetGroup>
