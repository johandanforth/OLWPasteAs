# Change Log

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## V1.0.1.4, 2019-11-12
### Changed
- `PRE` tags will be pasted in `<pre><code></code></pre>` format instead of `<pre></pre>` to follow [HTML 5](https://html.spec.whatwg.org/multipage/text-level-semantics.html#the-code-element) convention of embedding a `<code>` element inside the `<pre>`.

### Fixed
- The Plug-in will not paste the textbox contents if it's empty.

## V1.0.1.3, 2019-11-09
### Fixed
- RTF error handling that could cause a error message for the user when opening "Paste As" plugin.
- RTF parsing when user wasn't using Line Break conversion.

## V1.0.1.2, 2019-10-21
### Added
- It also gets wrapped in a `<code>` block.
- This plug-in will look for an RTF encoding of some code in the clipboard and convert it to HTML with <span> elements galore  using [RtfPipe](https://github.com/erdomke/RtfPipe).

## V1.0.1.1, 2006-10-14
### Added
- "Convert Line Feeds into <BR> tags?" option.
	By default newlines/Linefeeds/etc are converted now into <BR> tags. 
		This conversion can be turned off by unchecking it.

## V1.0.0.0, 2006-02-10
- First public release
