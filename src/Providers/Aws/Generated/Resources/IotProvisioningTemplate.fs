namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> = { assignments: ResizeArray<aws.IotProvisioningTemplate.IotProvisioningTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template">aws_iot_provisioning_template</a>.
    /// </summary>
    type IotProvisioningTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotProvisioningTemplateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotProvisioningTemplateState<Missing, Missing, Missing>)

        member _.Zero(()) : IotProvisioningTemplateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotProvisioningTemplateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#name-1">IotProvisioningTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotProvisioningTemplateState<Missing, 'ProvisioningRoleArn, 'TemplateBody>, value: string) : IotProvisioningTemplateState<Present, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotProvisioningTemplateState<Present, 'ProvisioningRoleArn, 'TemplateBody>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#provisioning_role_arn-1">IotProvisioningTemplate#provisioning_role_arn</a>.
        /// </summary>
        [<CustomOperation "provisioning_role_arn">]
        member _.ProvisioningRoleArn(state: IotProvisioningTemplateState<'Name, Missing, 'TemplateBody>, value: string) : IotProvisioningTemplateState<'Name, Present, 'TemplateBody> =
            state.assignments.Add(fun config -> config.ProvisioningRoleArn <- value)
            ({ assignments = state.assignments } : IotProvisioningTemplateState<'Name, Present, 'TemplateBody>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#template_body-1">IotProvisioningTemplate#template_body</a>.
        /// </summary>
        [<CustomOperation "template_body">]
        member _.TemplateBody(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, Missing>, value: string) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, Present> =
            state.assignments.Add(fun config -> config.TemplateBody <- value)
            ({ assignments = state.assignments } : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#description-1">IotProvisioningTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: string) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#enabled-1">IotProvisioningTemplate#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: bool) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#enabled-1">IotProvisioningTemplate#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: HashiCorp.Cdktf.IResolvable) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#id-1">IotProvisioningTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: string) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// pre_provisioning_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#pre_provisioning_hook-1">IotProvisioningTemplate#pre_provisioning_hook</a>
        /// </summary>
        [<CustomOperation "pre_provisioning_hook">]
        member _.PreProvisioningHook(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: aws.IotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHook) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.PreProvisioningHook <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#tags-1">IotProvisioningTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: seq<string * string>) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#tags_all-1">IotProvisioningTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: seq<string * string>) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#type-1">IotProvisioningTemplate#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>, value: string) : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : IotProvisioningTemplateState<'Name, 'ProvisioningRoleArn, 'TemplateBody>

        member _.Run(state: IotProvisioningTemplateState<Present, Present, Present>) : aws.IotProvisioningTemplate.IotProvisioningTemplate =
            let config = aws.IotProvisioningTemplate.IotProvisioningTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.IotProvisioningTemplate.IotProvisioningTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotProvisioningTemplate: missing required arguments. Must call: name, provisioning_role_arn, template_body.", 9999, IsError = true)>]
        member _.Run(_: IotProvisioningTemplateState<_, _, _>) : aws.IotProvisioningTemplate.IotProvisioningTemplate =
            Unchecked.defaultof<aws.IotProvisioningTemplate.IotProvisioningTemplate>
