namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbSubnetGroupState<'SubnetIds> = { assignments: ResizeArray<aws.MemorydbSubnetGroup.MemorydbSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group">aws_memorydb_subnet_group</a>.
    /// </summary>
    type MemorydbSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbSubnetGroupState<Missing>)

        member _.Zero(()) : MemorydbSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#subnet_ids-1">MemorydbSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: MemorydbSubnetGroupState<Missing>, value: seq<string>) : MemorydbSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MemorydbSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#description-1">MemorydbSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MemorydbSubnetGroupState<'SubnetIds>, value: string) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#id-1">MemorydbSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbSubnetGroupState<'SubnetIds>, value: string) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#name-1">MemorydbSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MemorydbSubnetGroupState<'SubnetIds>, value: string) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#name_prefix-1">MemorydbSubnetGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: MemorydbSubnetGroupState<'SubnetIds>, value: string) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#tags-1">MemorydbSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_subnet_group#tags_all-1">MemorydbSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbSubnetGroupState<'SubnetIds>, value: seq<string * string>) : MemorydbSubnetGroupState<'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbSubnetGroupState<'SubnetIds>

        member _.Run(state: MemorydbSubnetGroupState<Present>) : aws.MemorydbSubnetGroup.MemorydbSubnetGroup =
            let config = aws.MemorydbSubnetGroup.MemorydbSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbSubnetGroup.MemorydbSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbSubnetGroup: missing required arguments. Must call: subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: MemorydbSubnetGroupState<_>) : aws.MemorydbSubnetGroup.MemorydbSubnetGroup =
            Unchecked.defaultof<aws.MemorydbSubnetGroup.MemorydbSubnetGroup>
