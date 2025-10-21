namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicecatalogProvisioningArtifactState<'ProductId> = { assignments: ResizeArray<aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifactConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact">aws_servicecatalog_provisioning_artifact</a>.
    /// </summary>
    type ServicecatalogProvisioningArtifactBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicecatalogProvisioningArtifactState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProvisioningArtifactState<Missing>)

        member _.Zero(()) : ServicecatalogProvisioningArtifactState<Missing> =
            ({ assignments = ResizeArray() } : ServicecatalogProvisioningArtifactState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#product_id-1">ServicecatalogProvisioningArtifact#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ServicecatalogProvisioningArtifactState<Missing>, value: string) : ServicecatalogProvisioningArtifactState<Present> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ServicecatalogProvisioningArtifactState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#accept_language-1">ServicecatalogProvisioningArtifact#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#active-1">ServicecatalogProvisioningArtifact#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: bool) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#active-1">ServicecatalogProvisioningArtifact#active</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "active">]
        member _.Active(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Active <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#description-1">ServicecatalogProvisioningArtifact#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#disable_template_validation-1">ServicecatalogProvisioningArtifact#disable_template_validation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_template_validation">]
        member _.DisableTemplateValidation(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: bool) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.DisableTemplateValidation <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#disable_template_validation-1">ServicecatalogProvisioningArtifact#disable_template_validation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_template_validation">]
        member _.DisableTemplateValidation(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: HashiCorp.Cdktf.IResolvable) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.DisableTemplateValidation <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#guidance-1">ServicecatalogProvisioningArtifact#guidance</a>.
        /// </summary>
        [<CustomOperation "guidance">]
        member _.Guidance(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Guidance <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#id-1">ServicecatalogProvisioningArtifact#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#name-1">ServicecatalogProvisioningArtifact#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#template_physical_id-1">ServicecatalogProvisioningArtifact#template_physical_id</a>.
        /// </summary>
        [<CustomOperation "template_physical_id">]
        member _.TemplatePhysicalId(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.TemplatePhysicalId <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#template_url-1">ServicecatalogProvisioningArtifact#template_url</a>.
        /// </summary>
        [<CustomOperation "template_url">]
        member _.TemplateUrl(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.TemplateUrl <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#timeouts-1">ServicecatalogProvisioningArtifact#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifactTimeouts) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_provisioning_artifact#type-1">ServicecatalogProvisioningArtifact#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ServicecatalogProvisioningArtifactState<'ProductId>, value: string) : ServicecatalogProvisioningArtifactState<'ProductId> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ServicecatalogProvisioningArtifactState<'ProductId>

        member _.Run(state: ServicecatalogProvisioningArtifactState<Present>) : aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifact =
            let config = aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifactConfig()
            for setter in state.assignments do
                setter config
            aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifact(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.servicecatalogProvisioningArtifact: missing required arguments. Must call: product_id.", 9999, IsError = true)>]
        member _.Run(_: ServicecatalogProvisioningArtifactState<_>) : aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifact =
            Unchecked.defaultof<aws.ServicecatalogProvisioningArtifact.ServicecatalogProvisioningArtifact>
