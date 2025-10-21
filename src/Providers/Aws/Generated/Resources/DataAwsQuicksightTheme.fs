namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQuicksightThemeState<'ThemeId> = { assignments: ResizeArray<aws.DataAwsQuicksightTheme.DataAwsQuicksightThemeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_theme">aws_quicksight_theme</a>.
    /// </summary>
    type DataAwsQuicksightThemeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQuicksightThemeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightThemeState<Missing>)

        member _.Zero(()) : DataAwsQuicksightThemeState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightThemeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_theme#theme_id-1">DataAwsQuicksightTheme#theme_id</a>.
        /// </summary>
        [<CustomOperation "theme_id">]
        member _.ThemeId(state: DataAwsQuicksightThemeState<Missing>, value: string) : DataAwsQuicksightThemeState<Present> =
            state.assignments.Add(fun config -> config.ThemeId <- value)
            ({ assignments = state.assignments } : DataAwsQuicksightThemeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_theme#aws_account_id-1">DataAwsQuicksightTheme#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DataAwsQuicksightThemeState<'ThemeId>, value: string) : DataAwsQuicksightThemeState<'ThemeId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DataAwsQuicksightThemeState<'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_theme#id-1">DataAwsQuicksightTheme#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQuicksightThemeState<'ThemeId>, value: string) : DataAwsQuicksightThemeState<'ThemeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQuicksightThemeState<'ThemeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_theme#tags-1">DataAwsQuicksightTheme#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsQuicksightThemeState<'ThemeId>, value: seq<string * string>) : DataAwsQuicksightThemeState<'ThemeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsQuicksightThemeState<'ThemeId>

        member _.Run(state: DataAwsQuicksightThemeState<Present>) : aws.DataAwsQuicksightTheme.DataAwsQuicksightTheme =
            let config = aws.DataAwsQuicksightTheme.DataAwsQuicksightThemeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQuicksightTheme.DataAwsQuicksightTheme(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQuicksightTheme: missing required arguments. Must call: theme_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQuicksightThemeState<_>) : aws.DataAwsQuicksightTheme.DataAwsQuicksightTheme =
            Unchecked.defaultof<aws.DataAwsQuicksightTheme.DataAwsQuicksightTheme>
