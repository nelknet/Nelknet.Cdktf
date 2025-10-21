namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> = { assignments: ResizeArray<azurerm.BatchCertificate.BatchCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate">azurerm_batch_certificate</a>.
    /// </summary>
    type BatchCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchCertificateState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchCertificateState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BatchCertificateState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchCertificateState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#account_name-1">BatchCertificate#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: BatchCertificateState<Missing, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<Present, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : BatchCertificateState<Present, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#certificate-1">BatchCertificate#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: BatchCertificateState<'AccountName, Missing, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, Present, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            ({ assignments = state.assignments } : BatchCertificateState<'AccountName, Present, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#format-1">BatchCertificate#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: BatchCertificateState<'AccountName, 'Certificate, Missing, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, 'Certificate, Present, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : BatchCertificateState<'AccountName, 'Certificate, Present, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#resource_group_name-1">BatchCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, Missing, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, 'Certificate, 'Format, Present, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BatchCertificateState<'AccountName, 'Certificate, 'Format, Present, 'Thumbprint, 'ThumbprintAlgorithm>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#thumbprint-1">BatchCertificate#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, Missing, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, Present, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            ({ assignments = state.assignments } : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, Present, 'ThumbprintAlgorithm>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#thumbprint_algorithm-1">BatchCertificate#thumbprint_algorithm</a>.
        /// </summary>
        [<CustomOperation "thumbprint_algorithm">]
        member _.ThumbprintAlgorithm(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, Missing>, value: string) : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, Present> =
            state.assignments.Add(fun config -> config.ThumbprintAlgorithm <- value)
            ({ assignments = state.assignments } : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#id-1">BatchCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#password-1">BatchCertificate#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: string) : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_certificate#timeouts-1">BatchCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>, value: azurerm.BatchCertificate.BatchCertificateTimeouts) : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchCertificateState<'AccountName, 'Certificate, 'Format, 'ResourceGroupName, 'Thumbprint, 'ThumbprintAlgorithm>

        member _.Run(state: BatchCertificateState<Present, Present, Present, Present, Present, Present>) : azurerm.BatchCertificate.BatchCertificate =
            let config = azurerm.BatchCertificate.BatchCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.BatchCertificate.BatchCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.batchCertificate: missing required arguments. Must call: account_name, certificate, format, resource_group_name, thumbprint, thumbprint_algorithm.", 9999, IsError = true)>]
        member _.Run(_: BatchCertificateState<_, _, _, _, _, _>) : azurerm.BatchCertificate.BatchCertificate =
            Unchecked.defaultof<azurerm.BatchCertificate.BatchCertificate>
