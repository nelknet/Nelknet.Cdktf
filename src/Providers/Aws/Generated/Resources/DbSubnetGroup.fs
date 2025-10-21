namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbSubnetGroupState<'SubnetIds> = { assignments: ResizeArray<aws.DbSubnetGroup.DbSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group">aws_db_subnet_group</a>.
    /// </summary>
    type DbSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbSubnetGroupState<Missing>)

        member _.Zero(()) : DbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#subnet_ids-1">DbSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DbSubnetGroupState<Missing>, value: seq<string>) : DbSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DbSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#description-1">DbSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DbSubnetGroupState<'SubnetIds>, value: string) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#id-1">DbSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbSubnetGroupState<'SubnetIds>, value: string) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#name-1">DbSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DbSubnetGroupState<'SubnetIds>, value: string) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#name_prefix-1">DbSubnetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DbSubnetGroupState<'SubnetIds>, value: string) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#tags-1">DbSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_subnet_group#tags_all-1">DbSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : DbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbSubnetGroupState<'SubnetIds>

        member _.Run(state: DbSubnetGroupState<Present>) : aws.DbSubnetGroup.DbSubnetGroup =
            let config = aws.DbSubnetGroup.DbSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DbSubnetGroup.DbSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbSubnetGroup: missing required arguments. Must call: subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DbSubnetGroupState<_>) : aws.DbSubnetGroup.DbSubnetGroup =
            Unchecked.defaultof<aws.DbSubnetGroup.DbSubnetGroup>
