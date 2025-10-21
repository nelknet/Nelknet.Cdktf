namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbParameterGroupState<'Family> = { assignments: ResizeArray<aws.DbParameterGroup.DbParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group">aws_db_parameter_group</a>.
    /// </summary>
    type DbParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbParameterGroupState<Missing>)

        member _.Zero(()) : DbParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DbParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#family-1">DbParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: DbParameterGroupState<Missing>, value: string) : DbParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : DbParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#description-1">DbParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DbParameterGroupState<'Family>, value: string) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#id-1">DbParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbParameterGroupState<'Family>, value: string) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#name-1">DbParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DbParameterGroupState<'Family>, value: string) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#name_prefix-1">DbParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DbParameterGroupState<'Family>, value: string) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#parameter-1">DbParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.DbParameterGroup.DbParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: DbParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#skip_destroy-1">DbParameterGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DbParameterGroupState<'Family>, value: bool) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#skip_destroy-1">DbParameterGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DbParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#tags-1">DbParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbParameterGroupState<'Family>, value: seq<string * string>) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_parameter_group#tags_all-1">DbParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbParameterGroupState<'Family>, value: seq<string * string>) : DbParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbParameterGroupState<'Family>

        member _.Run(state: DbParameterGroupState<Present>) : aws.DbParameterGroup.DbParameterGroup =
            let config = aws.DbParameterGroup.DbParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DbParameterGroup.DbParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: DbParameterGroupState<_>) : aws.DbParameterGroup.DbParameterGroup =
            Unchecked.defaultof<aws.DbParameterGroup.DbParameterGroup>
