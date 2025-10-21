namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.AppServicePublicCertificate.AppServicePublicCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate">azurerm_app_service_public_certificate</a>.
    /// </summary>
    type AppServicePublicCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServicePublicCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServicePublicCertificateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServicePublicCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServicePublicCertificateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#app_service_name-1">AppServicePublicCertificate#app_service_name</a>.
        /// </summary>
        [<CustomOperation "app_service_name">]
        member _.AppServiceName(state: AppServicePublicCertificateState<Missing, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>, value: string) : AppServicePublicCertificateState<Present, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AppServiceName <- value)
            ({ assignments = state.assignments } : AppServicePublicCertificateState<Present, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#blob-1">AppServicePublicCertificate#blob</a>.
        /// </summary>
        [<CustomOperation "blob">]
        member _.Blob(state: AppServicePublicCertificateState<'AppServiceName, Missing, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>, value: string) : AppServicePublicCertificateState<'AppServiceName, Present, 'CertificateLocation, 'CertificateName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Blob <- value)
            ({ assignments = state.assignments } : AppServicePublicCertificateState<'AppServiceName, Present, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#certificate_location-1">AppServicePublicCertificate#certificate_location</a>.
        /// </summary>
        [<CustomOperation "certificate_location">]
        member _.CertificateLocation(state: AppServicePublicCertificateState<'AppServiceName, 'Blob, Missing, 'CertificateName, 'ResourceGroupName>, value: string) : AppServicePublicCertificateState<'AppServiceName, 'Blob, Present, 'CertificateName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CertificateLocation <- value)
            ({ assignments = state.assignments } : AppServicePublicCertificateState<'AppServiceName, 'Blob, Present, 'CertificateName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#certificate_name-1">AppServicePublicCertificate#certificate_name</a>.
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, Missing, 'ResourceGroupName>, value: string) : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            ({ assignments = state.assignments } : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#resource_group_name-1">AppServicePublicCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, Missing>, value: string) : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#id-1">AppServicePublicCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>, value: string) : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_public_certificate#timeouts-1">AppServicePublicCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>, value: azurerm.AppServicePublicCertificate.AppServicePublicCertificateTimeouts) : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServicePublicCertificateState<'AppServiceName, 'Blob, 'CertificateLocation, 'CertificateName, 'ResourceGroupName>

        member _.Run(state: AppServicePublicCertificateState<Present, Present, Present, Present, Present>) : azurerm.AppServicePublicCertificate.AppServicePublicCertificate =
            let config = azurerm.AppServicePublicCertificate.AppServicePublicCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServicePublicCertificate.AppServicePublicCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServicePublicCertificate: missing required arguments. Must call: app_service_name, blob, certificate_location, certificate_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: AppServicePublicCertificateState<_, _, _, _, _>) : azurerm.AppServicePublicCertificate.AppServicePublicCertificate =
            Unchecked.defaultof<azurerm.AppServicePublicCertificate.AppServicePublicCertificate>
