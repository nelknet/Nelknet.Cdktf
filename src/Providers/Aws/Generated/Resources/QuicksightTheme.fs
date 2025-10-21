namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> = { assignments: ResizeArray<aws.QuicksightTheme.QuicksightThemeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme">aws_quicksight_theme</a>.
    /// </summary>
    type QuicksightThemeBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightThemeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightThemeState<Missing, Missing, Missing>)

        member _.Zero(()) : QuicksightThemeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightThemeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#base_theme_id-1">QuicksightTheme#base_theme_id</a>.
        /// </summary>
        [<CustomOperation "base_theme_id">]
        member _.BaseThemeId(state: QuicksightThemeState<Missing, 'Name, 'ThemeId>, value: string) : QuicksightThemeState<Present, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.BaseThemeId <- value)
            ({ assignments = state.assignments } : QuicksightThemeState<Present, 'Name, 'ThemeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#name-1">QuicksightTheme#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: QuicksightThemeState<'BaseThemeId, Missing, 'ThemeId>, value: string) : QuicksightThemeState<'BaseThemeId, Present, 'ThemeId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : QuicksightThemeState<'BaseThemeId, Present, 'ThemeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#theme_id-1">QuicksightTheme#theme_id</a>.
        /// </summary>
        [<CustomOperation "theme_id">]
        member _.ThemeId(state: QuicksightThemeState<'BaseThemeId, 'Name, Missing>, value: string) : QuicksightThemeState<'BaseThemeId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ThemeId <- value)
            ({ assignments = state.assignments } : QuicksightThemeState<'BaseThemeId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#aws_account_id-1">QuicksightTheme#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: string) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#configuration-1">QuicksightTheme#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: aws.QuicksightTheme.QuicksightThemeConfiguration) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#id-1">QuicksightTheme#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: string) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#permissions-1">QuicksightTheme#permissions</a> Accepts: aws.IResolvable | aws.QuicksightTheme.QuicksightThemePermissions[]
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: HashiCorp.Cdktf.IResolvable) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tags-1">QuicksightTheme#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: seq<string * string>) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#tags_all-1">QuicksightTheme#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: seq<string * string>) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#timeouts-1">QuicksightTheme#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: aws.QuicksightTheme.QuicksightThemeTimeouts) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_theme#version_description-1">QuicksightTheme#version_description</a>.
        /// </summary>
        [<CustomOperation "version_description">]
        member _.VersionDescription(state: QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>, value: string) : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId> =
            state.assignments.Add(fun config -> config.VersionDescription <- value)
            state : QuicksightThemeState<'BaseThemeId, 'Name, 'ThemeId>

        member _.Run(state: QuicksightThemeState<Present, Present, Present>) : aws.QuicksightTheme.QuicksightTheme =
            let config = aws.QuicksightTheme.QuicksightThemeConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightTheme.QuicksightTheme(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightTheme: missing required arguments. Must call: base_theme_id, name, theme_id.", 9999, IsError = true)>]
        member _.Run(_: QuicksightThemeState<_, _, _>) : aws.QuicksightTheme.QuicksightTheme =
            Unchecked.defaultof<aws.QuicksightTheme.QuicksightTheme>
