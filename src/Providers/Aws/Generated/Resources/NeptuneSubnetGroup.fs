namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneSubnetGroupState<'SubnetIds> = { assignments: ResizeArray<aws.NeptuneSubnetGroup.NeptuneSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group">aws_neptune_subnet_group</a>.
    /// </summary>
    type NeptuneSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneSubnetGroupState<Missing>)

        member _.Zero(()) : NeptuneSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#subnet_ids-1">NeptuneSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: NeptuneSubnetGroupState<Missing>, value: seq<string>) : NeptuneSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NeptuneSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#description-1">NeptuneSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NeptuneSubnetGroupState<'SubnetIds>, value: string) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#id-1">NeptuneSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneSubnetGroupState<'SubnetIds>, value: string) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#name-1">NeptuneSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NeptuneSubnetGroupState<'SubnetIds>, value: string) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#name_prefix-1">NeptuneSubnetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: NeptuneSubnetGroupState<'SubnetIds>, value: string) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#tags-1">NeptuneSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneSubnetGroupState<'SubnetIds>, value: seq<string * string>) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_subnet_group#tags_all-1">NeptuneSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneSubnetGroupState<'SubnetIds>, value: seq<string * string>) : NeptuneSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneSubnetGroupState<'SubnetIds>

        member _.Run(state: NeptuneSubnetGroupState<Present>) : aws.NeptuneSubnetGroup.NeptuneSubnetGroup =
            let config = aws.NeptuneSubnetGroup.NeptuneSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneSubnetGroup.NeptuneSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneSubnetGroup: missing required arguments. Must call: subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: NeptuneSubnetGroupState<_>) : aws.NeptuneSubnetGroup.NeptuneSubnetGroup =
            Unchecked.defaultof<aws.NeptuneSubnetGroup.NeptuneSubnetGroup>
