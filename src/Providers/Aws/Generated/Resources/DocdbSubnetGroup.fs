namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbSubnetGroupState<'SubnetIds> = { assignments: ResizeArray<aws.DocdbSubnetGroup.DocdbSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group">aws_docdb_subnet_group</a>.
    /// </summary>
    type DocdbSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DocdbSubnetGroupState<Missing>)

        member _.Zero(()) : DocdbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DocdbSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#subnet_ids-1">DocdbSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DocdbSubnetGroupState<Missing>, value: seq<string>) : DocdbSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DocdbSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#description-1">DocdbSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DocdbSubnetGroupState<'SubnetIds>, value: string) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DocdbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#id-1">DocdbSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbSubnetGroupState<'SubnetIds>, value: string) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#name-1">DocdbSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DocdbSubnetGroupState<'SubnetIds>, value: string) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DocdbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#name_prefix-1">DocdbSubnetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DocdbSubnetGroupState<'SubnetIds>, value: string) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DocdbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#tags-1">DocdbSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_subnet_group#tags_all-1">DocdbSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DocdbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : DocdbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DocdbSubnetGroupState<'SubnetIds>

        member _.Run(state: DocdbSubnetGroupState<Present>) : aws.DocdbSubnetGroup.DocdbSubnetGroup =
            let config = aws.DocdbSubnetGroup.DocdbSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbSubnetGroup.DocdbSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbSubnetGroup: missing required arguments. Must call: subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: DocdbSubnetGroupState<_>) : aws.DocdbSubnetGroup.DocdbSubnetGroup =
            Unchecked.defaultof<aws.DocdbSubnetGroup.DocdbSubnetGroup>
