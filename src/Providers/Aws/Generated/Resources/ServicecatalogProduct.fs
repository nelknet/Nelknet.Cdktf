namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> = { assignments: ResizeArray<aws.ServicecatalogProduct.ServicecatalogProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product">aws_servicecatalog_product</a>.
    /// </summary>
    type ServicecatalogProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogProductState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProductState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServicecatalogProductState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProductState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#name-1">ServicecatalogProduct#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogProductState<Missing, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<Present, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicecatalogProductState<Present, 'Owner, 'ProvisioningArtifactParameters, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#owner-1">ServicecatalogProduct#owner</a>.
        /// </summary>
        [<CustomOperation "owner">]
        member _.Owner(state: ServicecatalogProductState<'Name, Missing, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, Present, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Owner <- value)
            ({ assignments = state.assignments } : ServicecatalogProductState<'Name, Present, 'ProvisioningArtifactParameters, 'Type>)

        /// <summary>
        /// provisioning_artifact_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#provisioning_artifact_parameters-1">ServicecatalogProduct#provisioning_artifact_parameters</a>
        /// </summary>
        [<CustomOperation "provisioning_artifact_parameters">]
        member _.ProvisioningArtifactParameters(state: ServicecatalogProductState<'Name, 'Owner, Missing, 'Type>, value: aws.ServicecatalogProduct.ServicecatalogProductProvisioningArtifactParameters) : ServicecatalogProductState<'Name, 'Owner, Present, 'Type> =
            state.assignments.Add(fun config -> config.ProvisioningArtifactParameters <- value)
            ({ assignments = state.assignments } : ServicecatalogProductState<'Name, 'Owner, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#type-1">ServicecatalogProduct#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, Missing>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#accept_language-1">ServicecatalogProduct#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#description-1">ServicecatalogProduct#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#distributor-1">ServicecatalogProduct#distributor</a>.
        /// </summary>
        [<CustomOperation "distributor">]
        member _.Distributor(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Distributor <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#id-1">ServicecatalogProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#support_description-1">ServicecatalogProduct#support_description</a>.
        /// </summary>
        [<CustomOperation "support_description">]
        member _.SupportDescription(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.SupportDescription <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#support_email-1">ServicecatalogProduct#support_email</a>.
        /// </summary>
        [<CustomOperation "support_email">]
        member _.SupportEmail(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.SupportEmail <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#support_url-1">ServicecatalogProduct#support_url</a>.
        /// </summary>
        [<CustomOperation "support_url">]
        member _.SupportUrl(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: string) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.SupportUrl <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#tags-1">ServicecatalogProduct#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: seq<string * string>) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#tags_all-1">ServicecatalogProduct#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: seq<string * string>) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_product#timeouts-1">ServicecatalogProduct#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>, value: aws.ServicecatalogProduct.ServicecatalogProductTimeouts) : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogProductState<'Name, 'Owner, 'ProvisioningArtifactParameters, 'Type>

        member _.Run(state: ServicecatalogProductState<Present, Present, Present, Present>) : aws.ServicecatalogProduct.ServicecatalogProduct =
            let config = aws.ServicecatalogProduct.ServicecatalogProductConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogProduct.ServicecatalogProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogProduct: missing required arguments. Must call: name, owner, provisioning_artifact_parameters, type.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogProductState<_, _, _, _>) : aws.ServicecatalogProduct.ServicecatalogProduct =
            Unchecked.defaultof<aws.ServicecatalogProduct.ServicecatalogProduct>
