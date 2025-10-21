namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbParameterGroupState<'Family> = { assignments: ResizeArray<aws.MemorydbParameterGroup.MemorydbParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group">aws_memorydb_parameter_group</a>.
    /// </summary>
    type MemorydbParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbParameterGroupState<Missing>)

        member _.Zero(()) : MemorydbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#family-1">MemorydbParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: MemorydbParameterGroupState<Missing>, value: string) : MemorydbParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : MemorydbParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#description-1">MemorydbParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MemorydbParameterGroupState<'Family>, value: string) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#id-1">MemorydbParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbParameterGroupState<'Family>, value: string) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#name-1">MemorydbParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MemorydbParameterGroupState<'Family>, value: string) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#name_prefix-1">MemorydbParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: MemorydbParameterGroupState<'Family>, value: string) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#parameter-1">MemorydbParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.MemorydbParameterGroup.MemorydbParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: MemorydbParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#tags-1">MemorydbParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbParameterGroupState<'Family>, value: seq<string * string>) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_parameter_group#tags_all-1">MemorydbParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbParameterGroupState<'Family>, value: seq<string * string>) : MemorydbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbParameterGroupState<'Family>

        member _.Run(state: MemorydbParameterGroupState<Present>) : aws.MemorydbParameterGroup.MemorydbParameterGroup =
            let config = aws.MemorydbParameterGroup.MemorydbParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbParameterGroup.MemorydbParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: MemorydbParameterGroupState<_>) : aws.MemorydbParameterGroup.MemorydbParameterGroup =
            Unchecked.defaultof<aws.MemorydbParameterGroup.MemorydbParameterGroup>
