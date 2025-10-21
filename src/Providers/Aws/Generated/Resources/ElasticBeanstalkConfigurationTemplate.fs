namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> = { assignments: ResizeArray<aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template">aws_elastic_beanstalk_configuration_template</a>.
    /// </summary>
    type ElasticBeanstalkConfigurationTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticBeanstalkConfigurationTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkConfigurationTemplateState<Missing, Missing>)

        member _.Zero(()) : ElasticBeanstalkConfigurationTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkConfigurationTemplateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#application-1">ElasticBeanstalkConfigurationTemplate#application</a>.
        /// </summary>
        [<CustomOperation "application">]
        member _.Application(state: ElasticBeanstalkConfigurationTemplateState<Missing, 'Name>, value: string) : ElasticBeanstalkConfigurationTemplateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Application <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkConfigurationTemplateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#name-1">ElasticBeanstalkConfigurationTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticBeanstalkConfigurationTemplateState<'Application, Missing>, value: string) : ElasticBeanstalkConfigurationTemplateState<'Application, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkConfigurationTemplateState<'Application, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#description-1">ElasticBeanstalkConfigurationTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>, value: string) : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#environment_id-1">ElasticBeanstalkConfigurationTemplate#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>, value: string) : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            state : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#id-1">ElasticBeanstalkConfigurationTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>, value: string) : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>

        /// <summary>
        /// setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#setting-1">ElasticBeanstalkConfigurationTemplate#setting</a> Accepts: aws.IResolvable | aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplateSetting[]
        /// </summary>
        [<CustomOperation "setting">]
        member _.Setting(state: ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Setting <- value)
            state : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_configuration_template#solution_stack_name-1">ElasticBeanstalkConfigurationTemplate#solution_stack_name</a>.
        /// </summary>
        [<CustomOperation "solution_stack_name">]
        member _.SolutionStackName(state: ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>, value: string) : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.SolutionStackName <- value)
            state : ElasticBeanstalkConfigurationTemplateState<'Application, 'Name>

        member _.Run(state: ElasticBeanstalkConfigurationTemplateState<Present, Present>) : aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplate =
            let config = aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticBeanstalkConfigurationTemplate: missing required arguments. Must call: application, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticBeanstalkConfigurationTemplateState<_, _>) : aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplate =
            Unchecked.defaultof<aws.ElasticBeanstalkConfigurationTemplate.ElasticBeanstalkConfigurationTemplate>
