using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTheme
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTheme.QuicksightThemeConfigurationTypographyOutputReference), fullyQualifiedName: "aws.quicksightTheme.QuicksightThemeConfigurationTypographyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightThemeConfigurationTypographyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightThemeConfigurationTypographyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationTypographyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightThemeConfigurationTypographyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFontFamilies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFontFamilies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightTheme.IQuicksightThemeConfigurationTypographyFontFamilies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFontFamilies")]
        public virtual void ResetFontFamilies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fontFamilies", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamiliesList\"}")]
        public virtual aws.QuicksightTheme.QuicksightThemeConfigurationTypographyFontFamiliesList FontFamilies
        {
            get => GetInstanceProperty<aws.QuicksightTheme.QuicksightThemeConfigurationTypographyFontFamiliesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fontFamiliesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypographyFontFamilies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FontFamiliesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTheme.QuicksightThemeConfigurationTypography\"}", isOptional: true)]
        public virtual aws.QuicksightTheme.IQuicksightThemeConfigurationTypography? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTheme.IQuicksightThemeConfigurationTypography?>();
            set => SetInstanceProperty(value);
        }
    }
}
