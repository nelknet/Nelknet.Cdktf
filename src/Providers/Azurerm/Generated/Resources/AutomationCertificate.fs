namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AutomationCertificate.AutomationCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate">azurerm_automation_certificate</a>.
    /// </summary>
    type AutomationCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationCertificateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationCertificateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#automation_account_name-1">AutomationCertificate#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationCertificateState<Missing, 'Base64, 'Name, 'ResourceGroupName>, value: string) : AutomationCertificateState<Present, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationCertificateState<Present, 'Base64, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#base64-1">AutomationCertificate#base64</a>.
        /// </summary>
        [<CustomOperation "base64">]
        member _.Base64(state: AutomationCertificateState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : AutomationCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Base64 <- value)
            ({ assignments = state.assignments } : AutomationCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#name-1">AutomationCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationCertificateState<'AutomationAccountName, 'Base64, Missing, 'ResourceGroupName>, value: string) : AutomationCertificateState<'AutomationAccountName, 'Base64, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationCertificateState<'AutomationAccountName, 'Base64, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#resource_group_name-1">AutomationCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, Missing>, value: string) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#description-1">AutomationCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>, value: string) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#exportable-1">AutomationCertificate#exportable</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exportable">]
        member _.Exportable(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>, value: bool) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Exportable <- value)
            state : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#exportable-1">AutomationCertificate#exportable</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exportable">]
        member _.Exportable(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Exportable <- value)
            state : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#id-1">AutomationCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>, value: string) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_certificate#timeouts-1">AutomationCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>, value: azurerm.AutomationCertificate.AutomationCertificateTimeouts) : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationCertificateState<'AutomationAccountName, 'Base64, 'Name, 'ResourceGroupName>

        member _.Run(state: AutomationCertificateState<Present, Present, Present, Present>) : azurerm.AutomationCertificate.AutomationCertificate =
            let config = azurerm.AutomationCertificate.AutomationCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationCertificate.AutomationCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationCertificate: missing required arguments. Must call: automation_account_name, base64, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationCertificateState<_, _, _, _>) : azurerm.AutomationCertificate.AutomationCertificate =
            Unchecked.defaultof<azurerm.AutomationCertificate.AutomationCertificate>
