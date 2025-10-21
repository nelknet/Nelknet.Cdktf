namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationPython3Package.AutomationPython3PackageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package">azurerm_automation_python3_package</a>.
    /// </summary>
    type AutomationPython3PackageBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationPython3PackageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationPython3PackageState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationPython3PackageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationPython3PackageState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#automation_account_name-1">AutomationPython3Package#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationPython3PackageState<Missing, 'ContentUri, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<Present, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationPython3PackageState<Present, 'ContentUri, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#content_uri-1">AutomationPython3Package#content_uri</a>.
        /// </summary>
        [<CustomOperation "content_uri">]
        member _.ContentUri(state: AutomationPython3PackageState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentUri <- value)
            ({ assignments = state.assignments } : AutomationPython3PackageState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#name-1">AutomationPython3Package#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, Missing, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#resource_group_name-1">AutomationPython3Package#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, Missing>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#content_version-1">AutomationPython3Package#content_version</a>.
        /// </summary>
        [<CustomOperation "content_version">]
        member _.ContentVersion(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentVersion <- value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#hash_algorithm-1">AutomationPython3Package#hash_algorithm</a>.
        /// </summary>
        [<CustomOperation "hash_algorithm">]
        member _.HashAlgorithm(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HashAlgorithm <- value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#hash_value-1">AutomationPython3Package#hash_value</a>.
        /// </summary>
        [<CustomOperation "hash_value">]
        member _.HashValue(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HashValue <- value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#id-1">AutomationPython3Package#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: string) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#tags-1">AutomationPython3Package#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: seq<string * string>) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_python3_package#timeouts-1">AutomationPython3Package#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>, value: azurerm.AutomationPython3Package.AutomationPython3PackageTimeouts) : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationPython3PackageState<'AutomationAccountName, 'ContentUri, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationPython3PackageState<Present, Present, Present, Present>) : azurerm.AutomationPython3Package.AutomationPython3Package =
            let config = azurerm.AutomationPython3Package.AutomationPython3PackageConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationPython3Package.AutomationPython3Package(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationPython3Package: missing required arguments. Must call: automation_account_name, content_uri, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationPython3PackageState<_, _, _, _>) : azurerm.AutomationPython3Package.AutomationPython3Package =
            Unchecked.defaultof<azurerm.AutomationPython3Package.AutomationPython3Package>
