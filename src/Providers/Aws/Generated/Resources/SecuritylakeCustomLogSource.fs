namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecuritylakeCustomLogSourceState<'SourceName> = { assignments: ResizeArray<aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source">aws_securitylake_custom_log_source</a>.
    /// </summary>
    type SecuritylakeCustomLogSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecuritylakeCustomLogSourceState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeCustomLogSourceState<Missing>)

        member _.Zero(()) : SecuritylakeCustomLogSourceState<Missing> =
            ({ assignments = ResizeArray() } : SecuritylakeCustomLogSourceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#source_name-1">SecuritylakeCustomLogSource#source_name</a>.
        /// </summary>
        [<CustomOperation "source_name">]
        member _.SourceName(state: SecuritylakeCustomLogSourceState<Missing>, value: string) : SecuritylakeCustomLogSourceState<Present> =
            state.assignments.Add(fun config -> config.SourceName <- value)
            ({ assignments = state.assignments } : SecuritylakeCustomLogSourceState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#configuration-1">SecuritylakeCustomLogSource#configuration</a> Accepts: aws.IResolvable | aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSourceConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: SecuritylakeCustomLogSourceState<'SourceName>, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeCustomLogSourceState<'SourceName> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : SecuritylakeCustomLogSourceState<'SourceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#event_classes-1">SecuritylakeCustomLogSource#event_classes</a>.
        /// </summary>
        [<CustomOperation "event_classes">]
        member _.EventClasses(state: SecuritylakeCustomLogSourceState<'SourceName>, value: seq<string>) : SecuritylakeCustomLogSourceState<'SourceName> =
            state.assignments.Add(fun config -> config.EventClasses <- (value |> Seq.toArray))
            state : SecuritylakeCustomLogSourceState<'SourceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#source_version-1">SecuritylakeCustomLogSource#source_version</a>.
        /// </summary>
        [<CustomOperation "source_version">]
        member _.SourceVersion(state: SecuritylakeCustomLogSourceState<'SourceName>, value: string) : SecuritylakeCustomLogSourceState<'SourceName> =
            state.assignments.Add(fun config -> config.SourceVersion <- value)
            state : SecuritylakeCustomLogSourceState<'SourceName>

        member _.Run(state: SecuritylakeCustomLogSourceState<Present>) : aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSource =
            let config = aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSourceConfig()
            for setter in state.assignments do
                setter config
            aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securitylakeCustomLogSource: missing required arguments. Must call: source_name.", 9999, IsError = true)>]
        member _.Run(_: SecuritylakeCustomLogSourceState<_>) : aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSource =
            Unchecked.defaultof<aws.SecuritylakeCustomLogSource.SecuritylakeCustomLogSource>
