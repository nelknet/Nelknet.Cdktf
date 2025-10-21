namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username> = { assignments: ResizeArray<azurerm.MssqlJobCredential.MssqlJobCredentialConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential">azurerm_mssql_job_credential</a>.
    /// </summary>
    type MssqlJobCredentialBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlJobCredentialState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlJobCredentialState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlJobCredentialState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlJobCredentialState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#job_agent_id-1">MssqlJobCredential#job_agent_id</a>.
        /// </summary>
        [<CustomOperation "job_agent_id">]
        member _.JobAgentId(state: MssqlJobCredentialState<Missing, 'Name, 'Password, 'Username>, value: string) : MssqlJobCredentialState<Present, 'Name, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.JobAgentId <- value)
            ({ assignments = state.assignments } : MssqlJobCredentialState<Present, 'Name, 'Password, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#name-1">MssqlJobCredential#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlJobCredentialState<'JobAgentId, Missing, 'Password, 'Username>, value: string) : MssqlJobCredentialState<'JobAgentId, Present, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlJobCredentialState<'JobAgentId, Present, 'Password, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#password-1">MssqlJobCredential#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: MssqlJobCredentialState<'JobAgentId, 'Name, Missing, 'Username>, value: string) : MssqlJobCredentialState<'JobAgentId, 'Name, Present, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : MssqlJobCredentialState<'JobAgentId, 'Name, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#username-1">MssqlJobCredential#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, Missing>, value: string) : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#id-1">MssqlJobCredential#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username>, value: string) : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_job_credential#timeouts-1">MssqlJobCredential#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username>, value: azurerm.MssqlJobCredential.MssqlJobCredentialTimeouts) : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlJobCredentialState<'JobAgentId, 'Name, 'Password, 'Username>

        member _.Run(state: MssqlJobCredentialState<Present, Present, Present, Present>) : azurerm.MssqlJobCredential.MssqlJobCredential =
            let config = azurerm.MssqlJobCredential.MssqlJobCredentialConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlJobCredential.MssqlJobCredential(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlJobCredential: missing required arguments. Must call: job_agent_id, name, password, username.", 9999, IsError = true)>]
        member _.Run(_: MssqlJobCredentialState<_, _, _, _>) : azurerm.MssqlJobCredential.MssqlJobCredential =
            Unchecked.defaultof<azurerm.MssqlJobCredential.MssqlJobCredential>
