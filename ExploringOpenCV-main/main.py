import cv2

img = cv2.imread(r"ExploringOpenCV-main\test.jpg")



#img = cv2.resize(img, (500, 500))
print(img)

cv2.imshow('Result', img)

cv2.waitKey(0)