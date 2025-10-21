namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticBeanstalkEnvironmentState<'Application, 'Name> = { assignments: ResizeArray<aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment">aws_elastic_beanstalk_environment</a>.
    /// </summary>
    type ElasticBeanstalkEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticBeanstalkEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkEnvironmentState<Missing, Missing>)

        member _.Zero(()) : ElasticBeanstalkEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkEnvironmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#application-1">ElasticBeanstalkEnvironment#application</a>.
        /// </summary>
        [<CustomOperation "application">]
        member _.Application(state: ElasticBeanstalkEnvironmentState<Missing, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Application <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkEnvironmentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#name-1">ElasticBeanstalkEnvironment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticBeanstalkEnvironmentState<'Application, Missing>, value: string) : ElasticBeanstalkEnvironmentState<'Application, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkEnvironmentState<'Application, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#cname_prefix-1">ElasticBeanstalkEnvironment#cname_prefix</a>.
        /// </summary>
        [<CustomOperation "cname_prefix">]
        member _.CnamePrefix(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.CnamePrefix <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#description-1">ElasticBeanstalkEnvironment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#id-1">ElasticBeanstalkEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#platform_arn-1">ElasticBeanstalkEnvironment#platform_arn</a>.
        /// </summary>
        [<CustomOperation "platform_arn">]
        member _.PlatformArn(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.PlatformArn <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#poll_interval-1">ElasticBeanstalkEnvironment#poll_interval</a>.
        /// </summary>
        [<CustomOperation "poll_interval">]
        member _.PollInterval(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.PollInterval <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#setting-1">ElasticBeanstalkEnvironment#setting</a> Accepts: aws.IResolvable | aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironmentSetting[]
        /// </summary>
        [<CustomOperation "setting">]
        member _.Setting(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Setting <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#solution_stack_name-1">ElasticBeanstalkEnvironment#solution_stack_name</a>.
        /// </summary>
        [<CustomOperation "solution_stack_name">]
        member _.SolutionStackName(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.SolutionStackName <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#tags-1">ElasticBeanstalkEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: seq<string * string>) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#tags_all-1">ElasticBeanstalkEnvironment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: seq<string * string>) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#template_name-1">ElasticBeanstalkEnvironment#template_name</a>.
        /// </summary>
        [<CustomOperation "template_name">]
        member _.TemplateName(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.TemplateName <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#tier-1">ElasticBeanstalkEnvironment#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.Tier <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#version_label-1">ElasticBeanstalkEnvironment#version_label</a>.
        /// </summary>
        [<CustomOperation "version_label">]
        member _.VersionLabel(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.VersionLabel <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_environment#wait_for_ready_timeout-1">ElasticBeanstalkEnvironment#wait_for_ready_timeout</a>.
        /// </summary>
        [<CustomOperation "wait_for_ready_timeout">]
        member _.WaitForReadyTimeout(state: ElasticBeanstalkEnvironmentState<'Application, 'Name>, value: string) : ElasticBeanstalkEnvironmentState<'Application, 'Name> =
            state.assignments.Add(fun config -> config.WaitForReadyTimeout <- value)
            state : ElasticBeanstalkEnvironmentState<'Application, 'Name>

        member _.Run(state: ElasticBeanstalkEnvironmentState<Present, Present>) : aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironment =
            let config = aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticBeanstalkEnvironment: missing required arguments. Must call: application, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticBeanstalkEnvironmentState<_, _>) : aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironment =
            Unchecked.defaultof<aws.ElasticBeanstalkEnvironment.ElasticBeanstalkEnvironment>
