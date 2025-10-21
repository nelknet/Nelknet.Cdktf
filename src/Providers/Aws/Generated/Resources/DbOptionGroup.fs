namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbOptionGroupState<'EngineName, 'MajorEngineVersion> = { assignments: ResizeArray<aws.DbOptionGroup.DbOptionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group">aws_db_option_group</a>.
    /// </summary>
    type DbOptionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbOptionGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbOptionGroupState<Missing, Missing>)

        member _.Zero(()) : DbOptionGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbOptionGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#engine_name-1">DbOptionGroup#engine_name</a>.
        /// </summary>
        [<CustomOperation "engine_name">]
        member _.EngineName(state: DbOptionGroupState<Missing, 'MajorEngineVersion>, value: string) : DbOptionGroupState<Present, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.EngineName <- value)
            ({ assignments = state.assignments } : DbOptionGroupState<Present, 'MajorEngineVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#major_engine_version-1">DbOptionGroup#major_engine_version</a>.
        /// </summary>
        [<CustomOperation "major_engine_version">]
        member _.MajorEngineVersion(state: DbOptionGroupState<'EngineName, Missing>, value: string) : DbOptionGroupState<'EngineName, Present> =
            state.assignments.Add(fun config -> config.MajorEngineVersion <- value)
            ({ assignments = state.assignments } : DbOptionGroupState<'EngineName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#id-1">DbOptionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: string) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#name-1">DbOptionGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: string) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#name_prefix-1">DbOptionGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: string) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// option block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#option-1">DbOptionGroup#option</a> Accepts: aws.IResolvable | aws.DbOptionGroup.DbOptionGroupOption[]
        /// </summary>
        [<CustomOperation "option">]
        member _.Option(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: HashiCorp.Cdktf.IResolvable) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.Option <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#option_group_description-1">DbOptionGroup#option_group_description</a>.
        /// </summary>
        [<CustomOperation "option_group_description">]
        member _.OptionGroupDescription(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: string) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.OptionGroupDescription <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#skip_destroy-1">DbOptionGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: bool) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#skip_destroy-1">DbOptionGroup#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: HashiCorp.Cdktf.IResolvable) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#tags-1">DbOptionGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: seq<string * string>) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#tags_all-1">DbOptionGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: seq<string * string>) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#timeouts-1">DbOptionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbOptionGroupState<'EngineName, 'MajorEngineVersion>, value: aws.DbOptionGroup.DbOptionGroupTimeouts) : DbOptionGroupState<'EngineName, 'MajorEngineVersion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbOptionGroupState<'EngineName, 'MajorEngineVersion>

        member _.Run(state: DbOptionGroupState<Present, Present>) : aws.DbOptionGroup.DbOptionGroup =
            let config = aws.DbOptionGroup.DbOptionGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DbOptionGroup.DbOptionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbOptionGroup: missing required arguments. Must call: engine_name, major_engine_version.", 9999, IsError = true)>]
        member _.Run(_: DbOptionGroupState<_, _>) : aws.DbOptionGroup.DbOptionGroup =
            Unchecked.defaultof<aws.DbOptionGroup.DbOptionGroup>
