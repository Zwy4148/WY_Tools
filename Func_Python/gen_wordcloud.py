import datetime
import os.path

from wordcloud import WordCloud
from PIL import Image, ImageDraw
import numpy as np
import pandas as pd


class gen_wordcloud:
    def __init__(self):
        pass

    @staticmethod
    def hex_to_rgb(hex_color):
        # 确保输入以'#'开头，并且长度为7（包括'#'）
        hex_color = hex_color.lstrip('#')
        # 将十六进制字符串分割成红、绿、蓝三个部分
        rgb = tuple(int(hex_color[i:i + 2], 16) for i in (0, 2, 4))
        return rgb

    # 根据字体属性更改颜色
    def gen_color_func(self, color_id):
        rgb = self.hex_to_rgb(color_id)

        def color_func(word, /, font_size, position, random_state, **kwargs):
            # 返回一个rgb颜色元组
            return rgb

        return color_func

    def gen_wordcloud_photo(self, word_path, mask_path=None, color_id=None, color_jb=True,
                            font_path=None, width=1920, height=1080, margin=2,
                            ranks_only=None, prefer_horizontal=.9, scale=1,
                            color_func=None, max_words=200, min_font_size=4,
                            stopwords=None, random_state=None, background_color=None,
                            max_font_size=None, font_step=1, mode="RGBA",
                            relative_scaling='auto', regexp=None, collocations=True,
                            colormap=None, normalize_plurals=True, contour_width=0,
                            contour_color='black', repeat=False,
                            include_numbers=False, min_word_length=0, collocation_threshold=30):

        # 处理单词
        data_frame = pd.read_csv(word_path)
        word = data_frame['单词']
        freq = data_frame['占比']
        data_dict = {}
        for i in range(len(word)):
            data_dict[word[i]] = freq[i]

        # 处理mask
        if mask_path is not None:
            mask_imge = np.array(Image.open(mask_path))
        else:
            mask_imge = None

        # 获取颜色函数
        if color_jb:
            def color_func(word, /, font_size, position, random_state, **kwargs):
                return color_id
        else:
            color_func = self.gen_color_func(color_id)

        wordcloud = WordCloud(
            font_path=font_path,
            color_func=color_func,
            min_font_size=min_font_size,
            max_font_size=max_font_size,
            font_step=font_step,
            repeat=repeat,
            width=width,
            height=height,
            background_color=background_color,
            mode=mode,
            mask=mask_imge,
        ).generate_from_frequencies(data_dict)

        wordcloud_array = np.array(wordcloud)
        # 保存词云图片
        now_time = datetime.datetime.now().strftime("%Y-%m-%d_%H-%M-%S")
        file_name = f'{now_time}_wordcloud.png'
        wordcloud_image = Image.fromarray(wordcloud_array)
        wordcloud_image.save(file_name)
        current_directory = os.getcwd()
        print(os.path.join(current_directory, file_name))
        return os.path.join(current_directory, file_name)


# 可执行文件参数配置
import argparse


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--word_path", type=str, help="单词地址")
    parser.add_argument("--mask_path", default=None, type=str, help="遮罩地址")
    parser.add_argument("--background_color", default=None, type=str, help="背景颜色")
    parser.add_argument("--color_id", default="#FFFFFF", type=str, help="颜色id")
    parser.add_argument("--color_jb", default=None, type=str, help="颜色渐变开关")
    parser.add_argument("--font_path", default=None, type=str, help="字体路径")
    parser.add_argument("--width", default=1920, type=int, help="宽度")
    parser.add_argument("--height", default=1080, type=int, help="高度")
    parser.add_argument("--min_font_size", default=4, type=int, help="最小字体")
    parser.add_argument("--max_font_size", default=None, type=int, help="最大字体")
    parser.add_argument("--font_step", default=3, type=str, help="字间距")
    parser.add_argument("--mode", default="RGBA", type=str, help="颜色模式")
    parser.add_argument("--repeat", default=True, type=bool, help="是否重复")
    args = parser.parse_args()
    gwc = gen_wordcloud()
    gwc.gen_wordcloud_photo(word_path=args.word_path, mask_path=args.mask_path, color_id=args.color_id,
                            color_jb=args.color_jb, font_path=args.font_path, width=args.width, height=args.height,
                            min_font_size=args.min_font_size, max_font_size=args.max_font_size,
                            font_step=args.font_step,
                            mode=args.mode, repeat=args.repeat)


if __name__ == '__main__':
    main()
